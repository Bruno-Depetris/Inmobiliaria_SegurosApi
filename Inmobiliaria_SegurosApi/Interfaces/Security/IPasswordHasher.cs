namespace Inmobiliaria_SegurosApi.Interfaces.Security {
    public interface IPasswordHasher {
        string HashPassword(string password);
        bool VerifyPassword(string password, string hashedPassword);
        string GenerateRandomPassword(int length = 12);
        bool IsValidPassword(string password);
        string GenerateSalt();
    }
}
