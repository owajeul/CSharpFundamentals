using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class InputExtractor
    {
        public static List<int> GetHyphenSeparatedNumbers(string userInput)
        {
            var numbers = userInput.Trim().Split('-').Select(int.Parse).ToList();
            return numbers;
        }
    }

    public class ConsecutiveNumbers
    {
       public static bool IsIncrementalConsecutive(List<int> numbers)
       {
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] - numbers[i - 1] != 1) return false;
            }
            return true;
       }

       public static bool IsDecrementalConsecutive(List<int> numbers)
       {
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] - numbers[i - 1] != -1) return false;
            }
            return true;
        }
       public static bool IsConsecutiveSequence(List<int> numbers)
       {
            if(numbers.Count == 0) return false;
            if(numbers.Count == 1) return true;
            return IsIncrementalConsecutive(numbers) || IsDecrementalConsecutive(numbers);
       }

    }
}
