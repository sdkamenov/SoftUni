using System;

namespace DateModifier
{
    public class DateModifier
    {
        public static int CalculateDiff(string firstDate, string secondDate)
        {
            TimeSpan diff = DateTime.Parse(firstDate) - DateTime.Parse(secondDate);

            return Math.Abs(diff.Days);
        }
    }
}
