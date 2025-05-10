using System.Diagnostics;
using System.Text.Json;

namespace SanaVitaAPI.Middleware
{
    public class AuditMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AuditMiddleware> _logger;

        public AuditMiddleware(RequestDelegate next, ILogger<AuditMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var traceId = Activity.Current?.Id ?? context.TraceIdentifier;
            var method = context.Request.Method;

            // Só audita métodos modificadores
            if (method == "POST" || method == "PUT" || method == "DELETE")
            {
                var user = context.User.Identity?.Name ?? "anonymous";
                var path = context.Request.Path;

                var log = new
                {
                    Timestamp = DateTime.UtcNow,
                    TraceId = traceId,
                    User = user,
                    Method = method,
                    Path = path,
                    IP = context.Connection.RemoteIpAddress?.ToString()
                };

                _logger.LogInformation("AUDIT: {info}", JsonSerializer.Serialize(log));
            }

            await _next(context);
        }
    }

    public static class AuditMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuditLogging(this IApplicationBuilder app)
        {
            return app.UseMiddleware<AuditMiddleware>();
        }
    }
}
