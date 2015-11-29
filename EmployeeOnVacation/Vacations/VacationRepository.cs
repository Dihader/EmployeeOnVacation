using System;
using System.Collections.Generic;
using System.ComponentModel;
using EmployeeOnVacation.Vacations;

namespace EmployeeOnVacation
{
    public static class VacationRepository
    {
        static BindingList<Vacation> listVacations = new BindingList<Vacation>();

        public static BindingList<Vacation> GetAllVacations()
        {
            //DateTime dtStart = new DateTime(2015, 11, 10);
            //DateTime dtEnd = new DateTime(2015, 11, 10);
            //Vacation vacation = new SicknessVacation("1", EmployeeRepository.GetAllEmployee()[0], dtStart, dtEnd, "Comment", "№123");
            //listVacations.Add(vacation);
            return listVacations;
        }



        public static void Add(Vacation vacation)
        {
            listVacations.Add(vacation);
        }

        public static Vacation GetVacation(string name)
        {

            BindingList<Vacation> list = GetAllVacations();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == name)
                {
                    return list[i];
                }
            }
            return null;
        }
        public static BindingList<Vacation> GetListVacations(int ID)
        {
            BindingList<Vacation> list = GetAllVacations();
            BindingList<Vacation> newBindingList=new BindingList<Vacation>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].EmployeeOnVacation.ID == ID)
                {
                    newBindingList.Add(list[i]);
                }
            }
            return newBindingList;
        }

    }
}
