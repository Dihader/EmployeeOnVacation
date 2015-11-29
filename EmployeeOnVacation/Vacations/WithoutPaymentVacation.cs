using System;
using EmployeeOnVacation.Vacations;

namespace EmployeeOnVacation
{
    public class WithoutPaymentVacation:Vacation
    {
        public bool IsConfirmed { get; set; }
        public WithoutPaymentVacation(string name, Employee employee, DateTime dateStartVacation, DateTime dateEndVacation, string description,bool isConfirmed)
        {
            EmployeeOnVacation = employee;
            DateEndVacation = dateEndVacation;
            DateStartVacation = dateStartVacation;
            Description = description;
            Name = name;
            IsConfirmed = isConfirmed;
        }
    }
}