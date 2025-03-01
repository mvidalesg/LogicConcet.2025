namespace POOconcepts
{
    public abstract class Employee //// clase abstracta 
    {
        public Employee(int id, string firsName, string lastName, bool isActive, Date? bornDate, Date? hireDate)
        {
            Id = id;
            FirsName = firsName;
            LastName = lastName;
            IsActive = isActive;
            BornDate = bornDate;
            HireDate = hireDate;
        }

        public int Id { get; set; }
        public string FirsName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public bool IsActive { get; set; }

        public Date? BornDate { get; set; }
        public Date? HireDate { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{FirsName} {LastName}\n\t" +
                $"Is active.......:{IsActive,20}\n\t" +
                $"Born date ......:{BornDate,20}\n\t" +
                $"Hire date.......;{HireDate,20}";

        }

        public abstract decimal GetValueToPay(); /// metodo abstracto


    }
}
