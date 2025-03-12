using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOconcepts;

    public class ComissionEmployee : Employee
    {
        private float _comissionPercentasje;
        private decimal _sales;
    private int comissionPercentasje;

    public ComissionEmployee(int id, string firsName, string lastName, bool isActive, Date? bornDate, Date? hireDate, float comissionPercentasje, decimal sales) : base(id, firsName, lastName, isActive, bornDate, hireDate)
    {
        ComissionPercentasje = comissionPercentasje;
        Sales = sales;
    }

    public float ComissionPercentasje { get => _comissionPercentasje; set => _comissionPercentasje = ValidateComissionPercentasje(value); }
        public decimal Sales { get => _sales; set => _sales = ValidateSales(value); }

    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
            $"Comision %....:   {ComissionPercentasje,20:P2}\n\t" +
            $"Sales.........:{Sales,20:C2}\n\t" +
            $"value to pay...:  {GetValueToPay(),20:C2}";
    }



    public override decimal GetValueToPay()
        {
            return (decimal)_comissionPercentasje * _sales;
        }
    private float ValidateComissionPercentasje(float comissionPercentaje)
    {
        if (comissionPercentaje < 0 || comissionPercentaje > 0.3)
        {
            throw new Exception($"the comission percentaje: {comissionPercentaje:P2}. is less than $0.00.");
        }

        return comissionPercentasje;
    }
    private decimal ValidateSales(decimal sales)
        {
            if (Sales < 0)
            {
                throw new Exception($"the sales: {sales:C2}. is less than $0.00.");
            }

            return sales;
        }
    }

