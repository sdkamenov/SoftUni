using System;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)((double)years * 365.2422);
            int hours = days * 24;
            ulong minutes = (ulong)hours * 60;
            ulong seconds = (ulong)minutes * 60;
            ulong milliseconds = seconds * 1000;
            System.Numerics.BigInteger microseconds = System.Numerics.BigInteger.Multiply(milliseconds, 1000);
            System.Numerics.BigInteger nanoseconds = System.Numerics.BigInteger.Multiply(microseconds, 1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
