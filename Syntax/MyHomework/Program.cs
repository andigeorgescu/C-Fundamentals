
namespace MyHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var date1 = new DateTime(1994,06,23);
            var date2 = new DateTime(2015,04,24);

            var leaveDate1 = new DateTime(2015,04,29);
            var leaveDate2 = new DateTime(2015,04,29);

            

            Employee emp = new Employee("Georgescu", "Andi",date1, date2, 2500,new availableDaysOff(20,2015));
            //medical,holiday,other
            Leave leave1 = new Leave(leaveDate1,10,LeaveTypeEnum.Holiday);
            emp.AddNewLeave(leave1);
            emp.DisplayInfo();

            Console.WriteLine();

            //Exception
            //Leave leave2 = new Leave(leaveDate2,20,LeaveTypeEnum.Holiday);
            //emp.AddNewLeave(leave2);
            

            //ListLeave - Concediu existent
            Leave leave3 = new Leave(leaveDate2,2,LeaveTypeEnum.Medical);
           
            emp.AddNewLeave(leave3);
            
            emp.ShowListLeave(2015);
        }
    }
}
