using System;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberNights = int.Parse(Console.ReadLine());
            double discount = 0;
            double totalPriceStudio = 0;
            double totalPriceDouble = 0;
            double totalPriceSuite = 0;
            double priceSingleStudio = 0;
            double priceSingleDouble = 0;
            double priceSingleSuite = 0;

            if (month == "May" || month == "October")
            {
                discount = 0.05;
                priceSingleStudio = 50;
                priceSingleDouble = 65;
                priceSingleSuite = 75;

                if (numberNights > 7)
                {
                    totalPriceStudio = numberNights * (priceSingleStudio - (priceSingleStudio * discount));
                }
                else
                {
                    totalPriceStudio = numberNights * priceSingleStudio;
                }

                if (numberNights > 7 && month == "October")
                {
                    totalPriceStudio = totalPriceStudio - priceSingleStudio*0.95;
                }

                totalPriceDouble = numberNights * priceSingleDouble;
                totalPriceSuite = numberNights * priceSingleSuite;
                Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
                Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
                Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");
            }
            else if (month == "June" || month == "September")
            {
                discount = 0.10;
                priceSingleStudio = 60;
                priceSingleDouble = 72;
                priceSingleSuite = 82;

                if (numberNights > 14)
                {
                    totalPriceDouble = numberNights * (priceSingleDouble - (priceSingleDouble * discount));
                }
                else
                {
                    totalPriceDouble = numberNights * priceSingleDouble;
                }

                totalPriceStudio = numberNights * priceSingleStudio;

                if (numberNights > 7 && month == "September")
                {
                    totalPriceStudio = totalPriceStudio - priceSingleStudio;
                }

                totalPriceSuite = numberNights * priceSingleSuite;
                Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
                Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
                Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");
            }
            if (month == "July" || month == "August" || month == "December")
            {
                discount = 0.15;
                priceSingleStudio = 68;
                priceSingleDouble = 77;
                priceSingleSuite = 89;

                if (numberNights > 14)
                {
                    totalPriceSuite = numberNights * (priceSingleSuite - (priceSingleSuite * discount));
                }
                else
                {
                    totalPriceSuite = numberNights * priceSingleSuite;
                }
                totalPriceDouble = numberNights * priceSingleDouble;
                totalPriceStudio = numberNights * priceSingleStudio;
                Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
                Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
                Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");
            }

        }
    }
}
/* different solution:
using System;
 
public class Hotel
{
    public static void Main()
    {
        double priceStudio = 0;
        double priceDouble = 0;
        double priceSuite = 0;
 
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());
 
        switch (month)
        {
            case "May":
            case "October": priceStudio = 50; priceDouble = 65; priceSuite = 75; break;
            case "June":
            case "September": priceStudio = 60; priceDouble = 72; priceSuite = 82; break;
            case "July":
            case "August":
            case "December": priceStudio = 68; priceDouble = 77; priceSuite = 89; break;
        }
 
        if ((month == "May" || month == "October") && nights > 7)
        {
            priceStudio *= 0.95;
        }
        else if ((month == "June" || month == "September") && nights > 14)
        {
            priceDouble *= 0.9;
        }
        else if ((month == "July" || month == "August" || month == "December") && nights > 14)
        {
            priceSuite *= 0.85;
        }
 
        double endPriceStudio = priceStudio * nights;
        double endPriceDouble = priceDouble * nights;
        double endPriceSuite = priceSuite * nights;
 
        if ((month == "September" || month == "October") && nights > 7)
        {
            endPriceStudio -= priceStudio;      
        }
 
        Console.WriteLine($"Studio: {endPriceStudio:f2} lv.");
        Console.WriteLine($"Double: {endPriceDouble:f2} lv.");
        Console.WriteLine($"Suite: {endPriceSuite:f2} lv.");
    }
}
*/