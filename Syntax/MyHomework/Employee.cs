
namespace MyHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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

    public class availableDaysOff
    {

       
        public int availableDays
        {
            get
            {
                return availableDays;
                
            }
            set
            {
                availableDays = value;
                
            }
        }


        public int workingYear
        {
            get
            {
                return workingYear;
                
            }
            set
            {
                workingYear = value;
                
            }
        }
        public availableDaysOff(int availableDays,int workingDateTime)
        {
            this.availableDays = availableDays;
            this.workingYear = workingDateTime;
        }
    }

    class Employee:Person
    {
        private DateTime? dateOfEmployment;
        private availableDaysOff daysOff;
        private double salary;
        List<Leave> ListLeave = new List<Leave>();

        public Employee(string lastName, string firstName, DateTime dateOfBirth, DateTime dateOfEmployment, double salary, availableDaysOff daysOff): base(lastName,firstName,dateOfBirth)
        {
            this.dateOfEmployment = dateOfEmployment;
            this.salary = salary;
            this.daysOff = daysOff;

        }


        public void DisplayInfo()
        {
            Console.WriteLine(firstName +" " + lastName +" Salary:" + salary + " Available Days Off:"+ daysOff.availableDays);
        }

        private void SubstractDays(int numberOfDaysSubstracted)
        {
            this.daysOff.availableDays -= numberOfDaysSubstracted;
        }

        
     

        public void ShowListLeave(int year)
        {
            foreach(var leave in ListLeave)
            {
                if(leave.startingDate.Year == year)
                Console.WriteLine(leave.startingDate + " " + leave.duration + " days");
            }
        }

        public bool ValidateLeave(Leave leave)
        {
            foreach (var lv in ListLeave)
            {
                if (lv.startingDate==leave.startingDate) return false;
            }
            
            return true;
        }
        public void AddNewLeave(Leave leave)
        {
            leave.employee = this;
            try
            {
                if (this.daysOff.availableDays-leave.duration<0 && leave.startingDate.Year==daysOff.workingYear) 
                    throw new MyException("Angajatul nu are destule zile libere!Mai are:"+this.daysOff.availableDays+" zile libere.");
                
                SubstractDays(leave.duration);

                if(ValidateLeave(leave))
                    ListLeave.Add(leave);
                else throw  new MyException("Concediul este deja existent!");
                
            }
            catch (MyException ex)
            {
                Console.Write(ex);
               
            }
            

        }
    }
}
