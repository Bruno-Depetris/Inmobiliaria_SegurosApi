namespace Inmobiliaria_SegurosApi.Interfaces.Utils {
    public interface IDateTimeProvider {
        DateTime Now { get; }
        DateTime UtcNow { get; }
        DateOnly Today { get; }
        TimeOnly CurrentTime { get; }
        DateTime StartOfDay(DateTime date);
        DateTime EndOfDay(DateTime date);
        DateTime StartOfMonth(DateTime date);
        DateTime EndOfMonth(DateTime date);
        bool IsBusinessDay(DateTime date);
        DateTime AddBusinessDays(DateTime date, int businessDays);
        int GetBusinessDaysBetween(DateTime startDate, DateTime endDate);
    }
}
