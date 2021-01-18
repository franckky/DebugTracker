using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DebugTracker.Data.Enums
{
    public enum SourceEnum
    {
        [Description("Project Team")]
        ProjectTeam = 1,
        [Description("ICTA IT Team")]
        ICTAITTeam = 2,
        [Description("Biometics Team")]
        BiometicsTeam = 3,
        [Description("ICTA SR Team")]
        ICTASRTeam = 4,
        [Description("Sponsor")]
        Sponsor = 5,
        [Description("ICTA QA Team")]
        ICTAQATeam = 6,
    }
}
