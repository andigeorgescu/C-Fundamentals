using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum LeaveTypeEnum
{
    [Description("holiday")] Holiday,
    [Description("medical")]Medical,
    [Description("other")]Other
};
namespace MyHomework
{
    internal class Leave
    {
        public DateTime startingDate;
        public int duration;
        public LeaveTypeEnum leaveType;
        public Employee employee;
        

        public Leave(DateTime startingDate, int duration, LeaveTypeEnum leavetype)
        {
            this.startingDate = startingDate;
            this.duration = duration;
            this.leaveType = leavetype;
        }

    }
}
