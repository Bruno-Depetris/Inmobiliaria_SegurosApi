namespace Inmobiliaria_SegurosApi.Interfaces.Export {
    public interface IExcelService {
        Task<byte[]> ExportToExcelAsync<T>(IEnumerable<T> data, string sheetName = "Data");
        Task<byte[]> ExportMultipleSheetsAsync(Dictionary<string, object> sheets);
        Task<IEnumerable<T>> ImportFromExcelAsync<T>(byte[] fileContent, string sheetName = null) where T : new();
        Task<byte[]> GenerateTemplateAsync<T>(string sheetName = "Template");
        Task<bool> ValidateExcelFormatAsync<T>(byte[] fileContent);
    }
}
