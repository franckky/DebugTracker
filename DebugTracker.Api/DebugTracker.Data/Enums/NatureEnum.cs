using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DebugTracker.Data.Enums
{
    public enum NatureEnum
    {
        [Description("Anomaly")]
        Anomaly = 1,
        [Description("Evolution")]
        Evolution = 2,
    }
}
