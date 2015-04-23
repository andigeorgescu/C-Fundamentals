using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class MyException : ApplicationException
    {
        public void MyException1()
        {
            Console.WriteLine("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
        }
    }

    class Employee:Person
    {
        private DateTime? DateOfEmployment;
        private int Salary, AvailableDaysOff;

        public Employee()
        {
            this.DateOfEmployment = null;
            this.Salary = 0;
            this.AvailableDaysOff = 0;
        }

        public Employee(string lastName, string firstName, DateTime dateOfBirth, DateTime dateOfEmployment, int salary, int availableDaysOff): base(lastName,firstName,dateOfBirth)
        {
            this.DateOfEmployment = dateOfEmployment;
            this.Salary = salary;
            this.AvailableDaysOff = availableDaysOff;

        }

        public void DisplayInfo()
        {
            Console.WriteLine(FirstName +" " + LastName +" Salary:" + Salary + " Available Days Off:"+ AvailableDaysOff);
        }

        private void SubstractDays(int numberOfDaysSubstracted)
        {
            this.AvailableDaysOff -= numberOfDaysSubstracted;
        }

        List<Leave> ListLeave = new List<Leave>();
        DateTime dt = new DateTime(2015);

        public void ShowListLeave()
        {
            foreach(var leave in ListLeave)
            {
                if(leave.StartingDate.Year == 2015)
                Console.WriteLine(leave.StartingDate + " " + leave.Duration + " days");
            }
        }

        public void AddNewLeave(Leave leave)
        {
            leave.Employee = this;
            try
            {
                SubstractDays(leave.Duration);
                if(this.AvailableDaysOff<0) throw new MyException();
            }
            catch (MyException ex)
            {
                
               ex.MyException1();
            }
            ListLeave.Add(leave);

        }
    }
}
