using System;

namespace inheritance_project
{
    public class EmailNotification : Notification
    {
        public string Recipient {get; set;}
        public string SmtpProvider {get; set;}
        
        public EmailNotification(string body, string subject) : base(body, subject)
        {
        }

        public override void Transport()
        {
            throw new NotImplementedException();
        }
    }
}