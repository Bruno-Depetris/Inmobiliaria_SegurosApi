namespace Inmobiliaria_SegurosApi.Interfaces.Configuration {
    public interface IEmailConfiguration {
        string SmtpServer { get; }
        int SmtpPort { get; }
        string Username { get; }
        string Password { get; }
        string FromName { get; }
        string FromEmail { get; }
        bool EnableSsl { get; }
        string TemplatesPath { get; }
    }
}
