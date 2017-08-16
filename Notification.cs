using System;

namespace inheritance_project
{
    public abstract class Notification
    {
        public DateTime createdAt {get; set;} = DateTime.Now;
        public string Subject {get; set;}
        public string Body {get; set;}

        public Notification (string body, string subject)
        {
            this.Body = body;
            this.Subject = subject;
        }

        public abstract void Transport();
    }
}