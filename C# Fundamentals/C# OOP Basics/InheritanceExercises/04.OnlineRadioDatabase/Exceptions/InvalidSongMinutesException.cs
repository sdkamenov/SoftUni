﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongMinutesException : Exception
    {
        public override string Message
        {
            get { return "Song minutes should be between 0 and 14."; }
        }
    }
}
