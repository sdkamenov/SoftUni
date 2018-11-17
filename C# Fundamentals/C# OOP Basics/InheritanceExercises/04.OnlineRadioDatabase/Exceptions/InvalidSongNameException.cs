using System;
using System.Collections.Generic;
using System.Text;

namespace _04.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongNameException : Exception
    {
        public override string Message
        {
            get { return "Song name should be between 3 and 30 symbols."; }
        }
    }
}
