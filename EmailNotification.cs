using System;

namespace inheritance_project
{
    public class EmailNotification : Notification
    {
        public string Recipient {get; set;}
        public string SmtpProvider {get; set;}

        public EmailNotification(string body, string subject, string recipient, string smtpProvider) : base(body, subject)
        {
            this.Body = body;
            this.Subject = subject;
            this.Recipient = recipient;
            this.SmtpProvider = smtpProvider;
        }

        public override void Transport()
        {
            Console.WriteLine($"{Subject},{Body},{Recipient},{SmtpProvider}");
        }
    }
}