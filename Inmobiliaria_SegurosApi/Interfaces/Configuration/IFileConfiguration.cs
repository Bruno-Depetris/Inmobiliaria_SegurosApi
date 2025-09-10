namespace Inmobiliaria_SegurosApi.Interfaces.Configuration {
    public interface IFileConfiguration {
        string UploadPath { get; }
        string[] AllowedExtensions { get; }
        long MaxFileSize { get; }
        string BaseUrl { get; }
        string ContractsPath { get; }
        string InsurancesPath { get; }
        string PaymentsPath { get; }
        string PropertiesPath { get; }
    }
}
