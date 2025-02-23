namespace POOconcepts;

public class Date
{
    private int _day;
    private int _month;
    private int _year;
    private int month;

    public Date() /// constructor
    {
        _year = 1900;
        _month = 1;
        _day = 1;
    }
    public Date(int year, int month, int day)  //// constructor 
    {
        _year = year;
        _month = ValidateMonth(month);
        _day = ValidateDay(day);
    }
    public int Day 
    {
        get => _day;
        set => _day = value;
    
    }
    public int Month
    {
        get => _month;
        set => _month = value;

    }
    public int Year
    {
        get => _year;
        set => _year = value;

    }
    public override string ToString()
    {
        return $"{_year:0000}/{_month:00}/{_day:00}";
    }
    private int ValidateMonth(int month) /// metodo valida mes
    {
        if (month < 1 || month >12)
        {
            throw new ArgumentNullException($"The month: {month}, not is valid.");
        }
        return month;
    }
    private int ValidateDay(int day) /// metodo valida dia
    {
        if (day < 1)
        {
            throw new ArgumentNullException($"The day: {day}, not is valid.");
        }

        if (day == 29 && _month == 2 && isLeapYear(_year))
        {
            return day;
        }
        if ((day <= 28 && _month == 2) ||
            (day <= 30 && (_month == 4 || _month == 6 || _month == 9 || _month == 11)) ||
            (day <= 31 && (_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12)))
        {
            return day;
        }
        throw new ArgumentNullException($"The day: {day}, not is valid.");

    }
    private bool isLeapYear(int year) /// metodo valida año 
    {
        return year % 400 == 0 || year % 4 == 0 && year % 100 == 0;
    }
}
