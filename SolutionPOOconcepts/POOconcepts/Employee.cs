namespace POOconcepts
{
    public abstract class Employee
    {
        protected Employee(int id, string firsName, string lastName, bool isActive, Date? bornDate, Date? hireDate)
        {
            Id = id;
            FirsName = firsName;
            this.lastName = lastName;
            IsActive = isActive;
            BornDate = bornDate;
            HireDate = hireDate;
        }

        public int Id { get; set; }
        public string FirsName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        private bool IsActive { get; set; }

        public Date? BornDate { get; set; }
        public Date? HireDate { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{FirsName} {lastName}\n\t" +
                $"Is active.......:{IsActive}\n" +
                $"Born date ......:{BornDate}\n\t" +
                $"Hire date.......;{HireDate}";

        }




    }
}
