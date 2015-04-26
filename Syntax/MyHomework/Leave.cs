﻿
namespace MyHomework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    

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
