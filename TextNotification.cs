using System;

namespace inheritance_project
{
    public class TextNotification : Notification
    {
        public string Recipient {get; set;}
        public string SmsProvider {get; set;}

        public TextNotification(string body, string subject, string recipient, string smsProvider) : base(body, subject)
        {
            this.Body = body;
            this.Subject = subject;
            this.Recipient = recipient;
            this.SmsProvider = smsProvider;
        }

        public override void Transport()
        {
            Console.WriteLine($"{Subject},{Body},{Recipient},{SmsProvider}");
        }
    }
}