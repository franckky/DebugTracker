using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DebugTracker.Data.Entities
{
    public class Location
    {
        public int Id { get; set; }

        public string Label { get; set; }

        public int? OrderBy { get; set; }

        public List<System_Location> System_Locations { get; set; }
    }
}
