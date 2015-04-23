using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Leave
    {
        public DateTime StartingDate;
        public int Duration;
        public string LeaveType;
        public Employee Employee;
        

        public Leave(DateTime startingDate, int duration, string leavetype)
        {
            this.StartingDate = startingDate;
            this.Duration = duration;
            this.LeaveType = leavetype;
        }

    }
}
