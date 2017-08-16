using System;

namespace inheritance_project
{
    public class NoTransportException : Exception
    {
        public NoTransportException() :base("This is a custom Exception message.")
        {

        }
    }
}