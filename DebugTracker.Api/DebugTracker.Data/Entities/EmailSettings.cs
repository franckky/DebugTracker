using System;
using System.Collections.Generic;
using System.Text;

namespace DebugTracker.Data.Entities
{
    public class EmailSettings
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SenderName { get; set; }
        public string EmailSenderAccount { get; set; }
        public string EmailSenderPassword { get; set; }
        public string EmailSenderAddress { get; set; }
        public string EmailDefault { get; set; }
        public string Url { get; set; }
        public string EmailSenderTest { get; set; }
        public string MacroSystemResponsibleDIId { get; set; }
        public string MacroSystemResponsibleSRId { get; set; }
        public string MacroSystemResponsibleDMId { get; set; }
    }
   
}
