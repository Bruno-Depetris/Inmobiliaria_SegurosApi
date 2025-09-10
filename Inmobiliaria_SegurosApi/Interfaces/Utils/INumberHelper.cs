namespace Inmobiliaria_SegurosApi.Interfaces.Utils {
    public interface INumberHelper {
        string FormatCurrency(decimal amount, string currencySymbol = "$");
        string FormatPercentage(decimal percentage, int decimals = 2);
        decimal CalculatePercentage(decimal amount, decimal percentage);
        decimal CalculateCommission(decimal baseAmount, decimal commissionPercentage);
        decimal CalculateIncrement(decimal baseAmount, decimal incrementPercentage);
        bool IsValidDecimal(string value, out decimal result);
        decimal RoundToTwoDecimals(decimal value);
        string NumberToWords(decimal number);
    }
}
