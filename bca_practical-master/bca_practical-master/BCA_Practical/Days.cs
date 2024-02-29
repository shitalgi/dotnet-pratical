using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_Practical
{
    public enum Days
    {
        [Description("Start Day")]
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday, 
        Friday,
        [Description("Saturday (Holiday)")]
        Saturday
    }

}
