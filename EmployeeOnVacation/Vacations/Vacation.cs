using System;
namespace EmployeeOnVacation.Vacations
{
    public class Vacation:IVacation
    {
        public string Name { get; set; }
        public DateTime DateEndVacation { get; set; }
        public DateTime DateStartVacation { get; set; }
        public Employee EmployeeOnVacation { get; set; }
        public string Description;

        public virtual double GetMoneyVacation()
        {
            return 0;
        }
    }
}
