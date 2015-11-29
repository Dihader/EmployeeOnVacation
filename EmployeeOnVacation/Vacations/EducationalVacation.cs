using System;
using EmployeeOnVacation.Vacations;

namespace EmployeeOnVacation
{
    public class EducationalVacation : Vacation
    {
        public EducationalVacation(string name, Employee employee, DateTime dateStartVacation, DateTime dateEndVacation, string description)
        {
            EmployeeOnVacation = employee;
            DateEndVacation = dateEndVacation;
            DateStartVacation = dateStartVacation;
            Description = description;
            Name = name;
        }

        public override double GetMoneyVacation()
        {
            TimeSpan ts = DateEndVacation - DateStartVacation;
            int day = ts.Days;
            return day * 250000;
        }
       
    }
}