using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOconcepts;

public class HourlyEmployee : Employee
{
    private int _workingHours;
    private decimal _valueHour;
    public HourlyEmployee(int id, string firsName, string lastName, bool isActive, Date? bornDate, Date? hireDate, int workingHours, decimal valueHour) : base(id, firsName, lastName, isActive, bornDate, hireDate)
    {
        _workingHours = workingHours;
        _valueHour = valueHour;
    }

    public int WorkingHours { get => _workingHours; set => _workingHours = ValidateWorkingHours(value); }
    public decimal ValueHour { get => _valueHour; set => _valueHour = ValidateValueHour(value); }

    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
            $"Working hours..:   {WorkingHours,20:N2}\n\t" +
            $"Working value.....:{ValueHour,20:C2}\n\t" +
            $"Working hours...:  {GetValueToPay(),20:C2}";
    }


    public override decimal GetValueToPay()
    {
        return ValueHour * WorkingHours;
    }
    private int ValidateWorkingHours(int workingHours)
    {
        if (workingHours < 0)
        {
            throw new Exception($"the working hours: {workingHours}. is not valid.");
        }

        return workingHours;
    }
    private decimal ValidateValueHour(decimal ValueHour)
    {
        if (ValueHour < 10000)
        {
            throw new Exception($"the value hours: {ValueHour:C2}. is less than $10.000.");
        }

        return ValueHour;
    }
}
