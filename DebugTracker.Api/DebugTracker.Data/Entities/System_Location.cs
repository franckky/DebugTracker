using System;
using System.Collections.Generic;
using System.Text;

namespace Icta.RequestTracker.Data.Entities
{
    public class System_Location
    {
        public int SystemId { get; set; }
        public SystemEntity System { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
