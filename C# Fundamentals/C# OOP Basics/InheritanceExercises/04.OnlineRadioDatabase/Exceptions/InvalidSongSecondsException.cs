﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongSecondsException : Exception
    {
        public override string Message
        {
            get { return "Song seconds should be between 0 and 59."; }
        }
    }
}
