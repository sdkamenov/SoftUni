using System;

namespace Problem06.DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {

            int matchSum = int.Parse(Console.ReadLine());
            string xOrO = string.Empty;
            string firstChar = string.Empty;
            string secondChar = string.Empty;
            string thirdChar = string.Empty;


            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {

                        xOrO = matchSum > i + j + k ? "X" : "O";

                        //ternary operator """""""condition ? first_expression : second_expression;"""""""
                         
                        //if (input > 0)
                        //    classify = "positive";
                        //else
                        //    classify = "negative";

                        // ?: conditional operator.  
                        //classify = (input > 0) ? "positive" : "negative";

                        //if (matchSum > i + j + k)
                        //{
                        //    xOrO = "X";
                        //}
                        //else
                        //{
                        //    xOrO = "O";
                        //}

                        firstChar = i == 1 ? "A" : i == 2 ? "C" : i == 3 ? "G" : "T";
                        secondChar = j == 1 ? "A" : j == 2 ? "C" : j == 3 ? "G" : "T";
                        thirdChar = k == 1 ? "A" : k == 2 ? "C" : k == 3 ? "G" : "T" ;

                        Console.Write($"{xOrO}{firstChar}{secondChar}{thirdChar}{xOrO} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}


/* array solution:
using System;

public class DNA_Sequences
{
    public static void Main()
    {
        var nucleicSequences = new char[] { 'A', 'C', 'G', 'T' };
        var nucleicValues = new int[] { 1, 2, 3, 4 };

        var sequence = string.Empty;
        
        var matchSum = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    var firstNucleotide = nucleicSequences[i];
                    var secondNucleotide = nucleicSequences[j];
                    var thirdNucleotide = nucleicSequences[k];

                    var currentSum = nucleicValues[i] + nucleicValues[j] + nucleicValues[k];

                    var symbol = "X";

                    if (currentSum >= matchSum)
                    {
                        symbol = "O";
                        sequence = symbol + firstNucleotide + secondNucleotide + thirdNucleotide + symbol;
                    }

                    else
                    {
                        sequence = symbol + firstNucleotide + secondNucleotide + thirdNucleotide + symbol;
                    }

                    Console.Write(sequence + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
*/
