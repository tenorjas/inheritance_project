using System;

namespace inheritance_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new EmailNotification("Hey, how are you?","Hi","Korri","gmail");
            email.Transport();

            var text = new TextNotification("I just got home, resting up","At home","Dad","AT&T");
            text.Transport();
        }
    }
}
