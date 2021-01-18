using System;
using System.Collections.Generic;
using DebugTracker.Data.Enums;

namespace DebugTracker.Data.Entities
{
    public class Request
    {
        public virtual int Id { get; set; }
        public virtual string Issuer { get; set; }
        public virtual string Reference { get; set; }
        public virtual string Subject { get; set; }
        public virtual int StudyId { get; set; }
        public virtual NatureEnum Nature { get; set; }
        public virtual int MacroSystemId { get; set; }
        public virtual MacroSystem MacroSystem { get; set; }
        public virtual int SystemId { get; set; }
        public virtual SystemEntity System { get; set; }
        public virtual int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual string LocationDetails { get; set; }
        public virtual SeriousnessEnum Seriousness { get; set; }
        public virtual ImpactEnum Impact { get; set; }
        public virtual string ImpactComment { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime? Deadline { get; set; }
        public virtual IEnumerable<RequestStatus> RequestStatus { get; set; }
        public virtual int ActionResponsibleId { get; set; }
        public virtual int ValidationResponsibleId { get; set; }
        public virtual SourceEnum Source { get; set; }
        public virtual ReleaseEnum? Release { get; set; }
        public virtual string ActionComment { get; set; }
    }

}
