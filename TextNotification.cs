using System;

namespace inheritance_project
{
    public class TextNotification : Notification
    {
        public string Recipient {get; set;}
        public string SmsProvider {get; set;}
        
        public TextNotification(string body, string subject) : base(body, subject)
        {
        }

        public override void Transport()
        {
            throw new NotImplementedException();
        }
    }
}