using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DebugTracker.Data.Enums
{
    public enum StudyStatusEnum
    {
        [Description("Archived")]
        Archived = 749690003,
        [Description("Services over")]
        ServicesOver = 749690001,
        [Description("On going")]
        Ongoing = 749690000,
    }
}
