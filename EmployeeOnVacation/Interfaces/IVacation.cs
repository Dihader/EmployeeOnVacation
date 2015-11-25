using System;

namespace EmployeeOnVacation
{
    public interface IVacation
    {
        DateTime DateStartVocation { get; set; }
        DateTime DateEndVocation { get; set; }
        Employee EmployeeOnVacation { get; set; }
        string Description { get; set; }
    }
}
