using System;
using System.Collections.Generic;
using Pustok.Database.Models;

namespace Pustok.Database.Models
{
    public class EmailMessage : AuditableEntity
    {
        public EmailMessage(string emailTitle, string emailContent, string[] emailRecipients)
        {
            EmailTitle = emailTitle;
            EmailContent = emailContent;
            EmailRecipients = emailRecipients;
        }

        public string EmailTitle { get; set; }
        public string EmailContent { get; set; }
        public string[] EmailRecipients { get; set; }
    }
}
