using System;
using System.Collections.Generic;
using EmployeeOnVacation.Vacations;

namespace EmployeeOnVacation
{
    public class SicknessVacation : Vacation
    {
        public string SickList { get; private set; }
   
        public SicknessVacation(string name,Employee employee, DateTime dateStartVacation, DateTime dateEndVacation, string description, string sickList)
        {
            EmployeeOnVacation = employee;
            DateEndVacation = dateEndVacation;
            DateStartVacation = dateStartVacation;
            Description = description;
            SickList = sickList;
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