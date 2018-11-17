using System;
using System.Collections.Generic;
using System.Text;

namespace _04.OnlineRadioDatabase.Exceptions
{
    public class InvalidArtistNameException : Exception
    {
        public override string Message
        {
            get { return "Artist name should be between 3 and 20 symbols."; }
        }
    }
}
