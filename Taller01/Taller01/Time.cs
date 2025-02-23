using System;
using System.Data;

namespace Taller01;

public class Time /// atributos privados/ campos
{
    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;
    

    public Time() // constructor sin parametros
    {
        _hour = 0;
        _minute = 0;
        _second = 0;
        _millisecond = 0;
    }
    public Time(int hour) // constructor con hora
    {
        ValidateHour(hour);
        _hour = hour;
        _minute = 0;
        _second = 0;
        _millisecond = 0;

    }


    public Time(int hour, int minute) // constructor con hora y minutos
    {
        ValidateHour(hour);
        ValidateMinute(minute);
        _hour = hour;
        _minute = minute;
        _second = 0;
        _millisecond = 0;

    }



    public Time(int hour, int minute, int second) // constructor con hora, minutos y segundos
    {
        ValidateHour(hour);
        ValidateMinute(minute);
        ValidateSecond(second);

        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = 0;

    }


    public Time(int hour, int minute, int second, int millisecond) // constructor con hora, minutos, segundos y milisegundos
    {
        ValidateHour(hour);
        ValidateMinute(minute);
        ValidateSecond(second);
        ValidateMillisecond(millisecond);

        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = millisecond;
    }
    public int Hour /// propiedades
    {
        get => _hour;
        set
        {
            ValidateHour(value);
            _hour = value;
        }

    }
    public int Millisecond /// propiedades
    {
        get => _millisecond;
        set
        {
            ValidateMillisecond(value);
            _millisecond = value;
        }
    }
    public int Minute /// propiedades
    {
        get => _minute;
        set
        {
            ValidateMinute(value);
            _minute = value;
        }
    }
    public int Second /// propiedades
    {
        get => _second;
        set
        {
            ValidateSecond(value);
            _second = value;
        }
    }

    public override string ToString()
    {
        int hour12 = _hour % 12;
        if (hour12 == 0)
        {
            hour12 = 12;
        }
        string ampm = _hour < 12 ? "AM" : "PM";

        return $"{hour12:00}:{_minute:00}:{_second:00}.{_millisecond:000} {ampm}";

    }
    private void ValidateHour(int hour)
    {
        if (hour < 0 || hour > 23)
        {
            throw new ArgumentOutOfRangeException(nameof(hour), $" the hour:{hour}, Hour must be between 0 and 23");
        }
      
    }

    private void ValidateMinute(int minute)
    {
        if (minute < 0 || minute > 59)
        {
            throw new ArgumentOutOfRangeException(nameof(minute), $" the minute {minute}, Minute must be between 0 and 59.");
        }
    }
        
    

    private void ValidateSecond(int second)
    {
        if (second < 0 || second > 59)
        {
            throw new ArgumentOutOfRangeException(nameof(second), $" the second {second}, second must be between 0 and 59.");
        }
        
    }
    private void ValidateMillisecond(int millisecond)
    {
        if (millisecond < 0 || millisecond > 999)
        {
            throw new ArgumentOutOfRangeException(nameof(millisecond), $" the millisecond {millisecond}, Millisecond must be between 0 and 999.");
        }
    }
    public long ToMilliseconds()
    {
        try
        {
            ValidateHour(_hour);
            ValidateMinute(_minute);
            ValidateSecond(_second);
            ValidateMillisecond(_millisecond);

            long totalMilliseconds = (_hour * 3600000L) + (_minute * 60000L) + (_second * 1000L) + _millisecond;
            return totalMilliseconds;
        }
        catch (ArgumentOutOfRangeException)
        {
            return 0; // Retorna 0 si la hora no es válida
        }
    }

    public long ToSeconds()
    {
        try
        {
            ValidateHour(_hour);
            ValidateMinute(_minute);
            ValidateSecond(_second);

            long totalSeconds = (_hour * 3600L) + (_minute * 60L) + _second;
            return totalSeconds;
        }
        catch (ArgumentOutOfRangeException)
        {
            return 0; // Retorna 0 si la hora no es válida
        }
    }

    public long ToMinutes()
    {
        try
        {
            ValidateHour(_hour);
            ValidateMinute(_minute);

            long totalMinutes = (_hour * 60L) + _minute;
            return totalMinutes;
        }
        catch (ArgumentOutOfRangeException)
        {
            return 0; // Retorna 0 si la hora no es válida
        }
    }

    public bool IsOtherDay(Time otherTime)
    {
        long totalMillisecondsThis = ToMilliseconds();
        long totalMillisecondsOther = otherTime.ToMilliseconds();

        return (totalMillisecondsThis + totalMillisecondsOther) >= 86400000; // 86400000 milisegundos en un día
    }

    public Time Add(Time otherTime)
    {
        long totalMillisecondsThis = ToMilliseconds();
        long totalMillisecondsOther = otherTime.ToMilliseconds();
        long totalMillisecondsSum = totalMillisecondsThis + totalMillisecondsOther;

        long newHour = (totalMillisecondsSum / 3600000) % 24;
        long newMinute = (totalMillisecondsSum / 60000) % 60;
        long newSecond = (totalMillisecondsSum / 1000) % 60;
        long newMillisecond = totalMillisecondsSum % 1000;

        return new Time((int)newHour, (int)newMinute, (int)newSecond, (int)newMillisecond);
    }
}

