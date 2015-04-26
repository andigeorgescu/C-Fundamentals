
namespace MyHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;

    public enum LeaveTypeEnum
    {
        [Description("holiday")]
        Holiday,
        [Description("medical")]
        Medical,
        [Description("other")]
        Other
    };
}
