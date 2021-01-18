using System;
using DebugTracker.Data.Enums;

namespace DebugTracker.Data.Entities
{
    public class RequestStatus
    {
        public int Id { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime? Date { get; set; }
        public int RequestId { get; set; }
        public string Description { get; set; }
        public int? ValidationResponsibleId { get; set; }
        public int? ActionResponsibleId { get; set; }

    }
}
