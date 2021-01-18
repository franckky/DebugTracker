using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DebugTracker.Data.Enums
{
    public enum StatusEnum
    {
        [Description("Issued")]
        Issued = 1,
        [Description("Planned")]
        Planned = 2,
        [Description("NotApplicable")]
        NotApplicable = 3,
        [Description("Performed")]
        Performed = 4,
        [Description("NotConsistent")]
        NotConsistent = 5,
        [Description("Approved")]
        Approved = 6,
        [Description("Release")]
        Release = 7,
        [Description("Closed")]
        Closed = 8,
        [Description("Programmed")]
        Programmed = 9,
    }
}
