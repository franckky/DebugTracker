using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DebugTracker.Data.Enums
{
    public enum ImpactEnum
    {
        [Description("Critical")]
        Critical = 1,
        [Description("Major")]
        Major = 2,
        [Description("Minor")]
        Minor = 3,
    }
}
