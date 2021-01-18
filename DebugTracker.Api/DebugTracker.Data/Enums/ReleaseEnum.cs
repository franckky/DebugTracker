using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DebugTracker.Data.Enums
{
    public enum ReleaseEnum
    {
        [Description("After System Release")]
        After = 1,
        [Description("Before System Release")]
        Before = 2,
    }
}
