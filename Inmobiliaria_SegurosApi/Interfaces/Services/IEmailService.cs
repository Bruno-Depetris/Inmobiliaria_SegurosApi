namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IEmailService {
        Task<bool> SendEmailAsync(string to, string subject, string body, bool isHtml = true);
        Task<bool> SendEmailAsync(List<string> to, string subject, string body, bool isHtml = true);
        Task<bool> SendEmailWithAttachmentAsync(string to, string subject, string body, byte[] attachment, string attachmentName, bool isHtml = true);
        Task<bool> SendTemplateEmailAsync(string to, string templateName, object templateData);
        Task<bool> SendBulkEmailAsync(List<string> recipients, string subject, string body, bool isHtml = true);
    }
}
