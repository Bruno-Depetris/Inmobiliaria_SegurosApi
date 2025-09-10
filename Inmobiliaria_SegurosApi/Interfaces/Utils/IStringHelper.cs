namespace Inmobiliaria_SegurosApi.Interfaces.Utils {
    public interface IStringHelper {
        string GenerateRandomString(int length, bool includeNumbers = true, bool includeSpecialChars = false);
        string SanitizeFileName(string fileName);
        string Slugify(string text);
        string TruncateText(string text, int maxLength, string suffix = "...");
        bool IsValidEmail(string email);
        bool IsValidPhoneNumber(string phoneNumber);
        string FormatPhoneNumber(string phoneNumber);
        string RemoveAccents(string text);
        string CapitalizeWords(string text);
        string GenerateCode(string prefix, int number, int totalLength = 8);
    }
}
