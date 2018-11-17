using System;

namespace _03.Mankind
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] secondInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                Student student = new Student(firstInput[0], firstInput[1], firstInput[2]);
                Worker worker = new Worker(secondInput[0], secondInput[1], decimal.Parse(secondInput[2]), decimal.Parse(secondInput[3]));

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
