namespace Domain.Models
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(int Legajo, int Dni, string Name)
        {
            this.Legajo = Legajo;
            this.Dni = Dni;
            this.Name = Name;
        }

        public int Legajo { get; set; }

        public int Dni { get; set; }

        public string Name { get; set; }
    }
}