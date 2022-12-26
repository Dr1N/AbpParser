namespace Application.Utils;

public static class DateParser
{
    private const char DateSeparator = '-';
    private const string NowDate = "...";
    private const char YearSeparator = '.';
    private const StringSplitOptions SplitOptions =
        StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries;
    
    public static (DateTime?, DateTime?) GetDates(string dates)
    {
        if (string.IsNullOrEmpty(dates))
        {
            return (null, null);
        }
        
        var parts = dates.Split(DateSeparator, SplitOptions);

        return parts.Length != 2 ? (null, null) : (ParseDate(parts[0]), ParseDate(parts[1]));
    }

    private static DateTime? ParseDate(string date)
    {
        if (date.Contains(NowDate))
        {
            return DateTime.Now;
        }
        
        var parts = date.Split(YearSeparator, SplitOptions);
        if (parts.Length != 2)
        {
            return null;
        }
        
        var month = int.Parse(parts[0]);
        var year = int.Parse(parts[1]);

        return new DateTime(year, month, 01);
    }
}
