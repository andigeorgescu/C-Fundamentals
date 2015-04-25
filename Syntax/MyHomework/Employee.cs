using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class MyException : Exception
    {
        public MyException()
        {
            
        }
         public MyException(string message)
            : base(message)
        {
        }
        public MyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    class Employee:Person
    {
        private DateTime? dateOfEmployment;
        private int salary, availableDaysOff;
        List<Leave> ListLeave = new List<Leave>();

        public Employee(string lastName, string firstName, DateTime dateOfBirth, DateTime dateOfEmployment, int salary, int availableDaysOff): base(lastName,firstName,dateOfBirth)
        {
            this.dateOfEmployment = dateOfEmployment;
            this.salary = salary;
            this.availableDaysOff = availableDaysOff;

        }


        public void DisplayInfo()
        {
            Console.WriteLine(firstName +" " + lastName +" Salary:" + salary + " Available Days Off:"+ availableDaysOff);
        }

        private void SubstractDays(int numberOfDaysSubstracted)
        {
            this.availableDaysOff -= numberOfDaysSubstracted;
        }

        
     

        public void ShowListLeave()
        {
            foreach(var leave in ListLeave)
            {
                if(leave.startingDate.Year == 2015)
                Console.WriteLine(leave.startingDate + " " + leave.duration + " days");
            }
        }

        public void AddNewLeave(Leave leave)
        {
            leave.employee = this;
            try
            {
                if (this.availableDaysOff-leave.duration<0) throw new MyException("Angajatul nu are destule zile libere!Mai are:"+this.availableDaysOff+" zile libere.");
                SubstractDays(leave.duration);
                ListLeave.Add(leave);
                
            }
            catch (MyException ex)
            {
                Console.Write(ex);
               
            }
            

        }
    }
}
