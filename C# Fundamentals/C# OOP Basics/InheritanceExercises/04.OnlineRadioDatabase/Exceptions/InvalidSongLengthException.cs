using System;
using System.Collections.Generic;
using System.Text;

namespace _04.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongLengthException : Exception
    {
        public override string Message
        {
            get { return "Invalid song length."; }
        }
    }
}
