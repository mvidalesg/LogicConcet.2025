namespace POOconcepts
{
    public class SalaryEmployee : Employee
    {
        private decimal _salary;

        public SalaryEmployee(int id, string firsName, string lastName, bool isActive, Date? bornDate, Date? hireDate, decimal salary) : base(id, firsName, lastName, isActive, bornDate, hireDate)
        {
            _salary = ValidateSalary(salary); // valida el salario en este cosntructor
        }

        public decimal Salary { get => _salary; set => _salary = ValidateSalary(value); } // propiedad 

        public override string ToString() /// sobrescribe el Tostring
        {
            return $"{base.ToString()}\n\t" +
                $"value to pay:...: {GetValueToPay(),20:C2}";

        }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        private decimal ValidateSalary(decimal salary) // metodo valida salario 
        {
            if (salary < 1000000)
            {
                throw new Exception($"The salary: {salary:C2}, is less than the minimun.");
            }
            return salary;
        }
    }
}
