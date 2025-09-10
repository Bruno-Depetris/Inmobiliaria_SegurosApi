namespace Inmobiliaria_SegurosApi.Interfaces.Export {
    public interface IPdfService {
        Task<byte[]> GenerateFromHtmlAsync(string htmlContent);
        Task<byte[]> GenerateReportAsync(string templateName, object data);
        Task<byte[]> GenerateContractAsync(int contratoId);
        Task<byte[]> GeneratePaymentReceiptAsync(int pagoId);
        Task<byte[]> GenerateInsurancePolicyAsync(int seguroId);
        Task<byte[]> MergePdfsAsync(List<byte[]> pdfFiles);
        Task<byte[]> AddWatermarkAsync(byte[] pdfContent, string watermarkText);
    }
}
