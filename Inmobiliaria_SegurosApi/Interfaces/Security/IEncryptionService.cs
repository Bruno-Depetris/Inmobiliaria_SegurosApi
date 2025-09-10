namespace Inmobiliaria_SegurosApi.Interfaces.Security {
    public interface IEncryptionService {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
        string GenerateRandomKey(int length = 32);
        byte[] GenerateRandomBytes(int length);
        string HashData(string data);
        bool VerifyHash(string data, string hash);
    }
}
