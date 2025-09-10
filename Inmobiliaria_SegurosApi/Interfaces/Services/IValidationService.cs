using Inmobiliaria_SegurosApi.DTOs.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IValidationService {
        Task<ResponseDTOs<bool>> ValidateEntityExistsAsync<T>(int id) where T : class;
        Task<ResponseDTOs<bool>> ValidateUniqueFieldAsync<T>(string fieldName, object fieldValue, int? excludeId = null) where T : class;
        Task<ResponseDTOs<bool>> ValidateBusinessRulesAsync(string entityType, object entity, string operation = "CREATE");
        Task<ResponseDTOs<bool>> ValidateContractBusinessRulesAsync(object contratoData);
        Task<ResponseDTOs<bool>> ValidatePaymentBusinessRulesAsync(object pagoData);
        Task<ResponseDTOs<bool>> ValidatePropertyBusinessRulesAsync(object propiedadData);
        ResponseDTOs<bool> ValidateDocumentNumber(string documentNumber, string documentType);
        ResponseDTOs<bool> ValidateEmail(string email);
        ResponseDTOs<bool> ValidatePhoneNumber(string phoneNumber);
    }
}
