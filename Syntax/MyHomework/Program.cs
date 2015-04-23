using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1994,06,23);
            DateTime dte= new DateTime(2015,04,24);
            DateTime leaveDate = new DateTime(2015,04,29);
            Employee emp = new Employee("Georgescu", "Andi",dt, dte, 2500, 20);
            //medical,holiday,other
            Leave leave1 = new Leave(leaveDate,10,"medical");
            emp.AddNewLeave(leave1);
            emp.DisplayInfo();

            Console.WriteLine();
            //Exception
            //Leave leave2 = new Leave(leaveDate,20,"holiday");
            //emp.AddNewLeave(leave2);
            

            //ListLeave
            Leave leave3 = new Leave(dte,2,"medical");
            emp.AddNewLeave(leave3);

            emp.ShowListLeave();
        }
    }
}
