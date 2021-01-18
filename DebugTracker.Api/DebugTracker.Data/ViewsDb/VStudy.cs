using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using DebugTracker.Data.Enums;
using DebugTracker.Data.Helpers;

namespace DebugTracker.Data.ViewsDb
{
    public class VStudy
    {
        public int ProjectId { get; set; }
        public string ShortTitle { get; set; }
        public string Sponsor { get; set; }
        public string Email { get; set; }
        public string StatusLabel { get; set; }

        [NotMapped]
        public StudyStatusEnum StatusLabelEnum { get => Enum.GetValues(typeof(StudyStatusEnum)).OfType<StudyStatusEnum>().FirstOrDefault(x => x.GetDescription() == StatusLabel); }
    }
}
