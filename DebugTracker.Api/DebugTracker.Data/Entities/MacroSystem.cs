using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DebugTracker.Data.Entities
{
    public class MacroSystem
    {
        public virtual int Id { get; set; }

        public virtual string Label { get; set; }

        public virtual string FullLabel { get; set; }

        public virtual int OrderBy { get; set; }

        public List<MacroSystem_System> MacroSystem_Systems { get; set; }

    }
 
}
