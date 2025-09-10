namespace Inmobiliaria_SegurosApi.Interfaces.Configuration {
    public interface IJwtConfiguration {
        string SecretKey { get; }
        string Issuer { get; }
        string Audience { get; }
        int AccessTokenExpirationMinutes { get; }
        int RefreshTokenExpirationDays { get; }
        string Algorithm { get; }
    }
}
