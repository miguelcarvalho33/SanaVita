using SanaVitaAPI.Services;

namespace SanaVitaAPI.Middleware
{
    public class FallbackCheckMiddleware
    {
        private readonly RequestDelegate _next;

        public FallbackCheckMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context, FallbackState fallback)
        {
            if (fallback.IsFallbackEnabled &&
                context.Request.Method != "GET" &&
                !context.Request.Path.StartsWithSegments("/api/fallback"))
            {
                context.Response.StatusCode = StatusCodes.Status503ServiceUnavailable;
                await context.Response.WriteAsJsonAsync(new
                {
                    message = "Sistema está em modo degradado. Apenas leitura disponível.",
                    fallback = true
                });
                return;
            }

            await _next(context);
        }
    }

    public static class FallbackCheckExtensions
    {
        public static IApplicationBuilder UseFallbackCheck(this IApplicationBuilder app)
        {
            return app.UseMiddleware<FallbackCheckMiddleware>();
        }
    }
}
