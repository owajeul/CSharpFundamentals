using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter hyphen separated number sequence.");
            var userInput = Console.ReadLine();

            List<int> numbers = InputExtractor.GetHyphenSeparatedNumbers(userInput);

            if(ConsecutiveNumbers.IsConsecutiveSequence(numbers))
            {
                Console.WriteLine("Consecutive.");
            }
            else
            {
                Console.WriteLine("Not consecutive.");
            }
           
        }
    }
}
