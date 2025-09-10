namespace Inmobiliaria_SegurosApi.Interfaces.Middlewares {
    public interface IExceptionHandlerService {
        Task<string> HandleExceptionAsync(Exception exception, HttpContext context);
        Task LogExceptionAsync(Exception exception, HttpContext context);
        bool ShouldExposeError(Exception exception);
        string GetUserFriendlyMessage(Exception exception);
        int GetStatusCode(Exception exception);
    }
}
