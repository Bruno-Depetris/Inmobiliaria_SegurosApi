namespace Inmobiliaria_SegurosApi.Interfaces.Middlewares {
    public interface IRequestLoggingService {
        Task LogRequestAsync(HttpRequest request, int? usuarioId = null);
        Task LogResponseAsync(HttpRequest request, HttpResponse response, TimeSpan elapsed, int? usuarioId = null);
        Task LogRequestResponseAsync(HttpContext context, TimeSpan elapsed, int? usuarioId = null);
        bool ShouldLogRequest(HttpRequest request);
        bool ShouldLogResponse(HttpResponse response);
    }
}
