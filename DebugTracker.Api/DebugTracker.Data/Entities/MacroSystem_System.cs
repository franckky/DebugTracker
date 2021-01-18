using System;
using System.Collections.Generic;
using System.Text;

namespace DebugTracker.Data.Entities
{
    public class MacroSystem_System
    {
        public int MacroSystemId { get; set; }
        public MacroSystem MacroSystem { get; set; }

        public int SystemId { get; set; }
        public SystemEntity System { get; set; }
    }
}
