using System.Net;
using System.Text.Json;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace SanaVitaAPI.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var traceId = Activity.Current?.Id ?? context.TraceIdentifier;

                // Classificação do erro
                var faultType = ClassifyException(ex);

                _logger.LogError(ex, "Erro não tratado | Tipo: {FaultType} | TraceId: {TraceId}", faultType, traceId);

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var response = new
                {
                    status = context.Response.StatusCode,
                    message = "Ocorreu um erro inesperado. A nossa equipa foi notificada.",
                    traceId = traceId,
                    faultCategory = faultType
                };

                var json = JsonSerializer.Serialize(response);
                await context.Response.WriteAsync(json);
            }
        }

        private string ClassifyException(Exception ex)
        {
            if (ex is DbUpdateException or InvalidOperationException)
                return "DataAccessError";

            if (ex is TimeoutException or TaskCanceledException)
                return "CommunicationFault";

            if (ex is UnauthorizedAccessException)
                return "AuthorizationError";

            return "ApplicationError";
        }
    }

    public static class ExceptionHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandling(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
