using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TechnicalInterviews.StringCalculator
{
    public class StringCalculator
    {
        public static string NegativeException = "Input String cannot be Negative";
        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            return Sum(numbers);
        }
        private static int Sum(string numbers)
        {
            var splitstrings = Regex.Split(numbers, @",|\n"); ;//numbers.Split(',');
            return splitstrings.Sum(n => CheckInteger(n));
        }
        //Functor
        private static int CheckInteger(string n)
        {
            var result = CheckGreaterThanThousand(Convert.ToInt32(n))
                             ? 0
                             : (Convert.ToInt32(string.IsNullOrEmpty(n) ? "0" : n));
            CheckNegative(result);
            return result;
        }

        private static void CheckNegative(int result)
        {
            if (result < 0)
                throw new ArgumentException(
                    string.Format(
                        NegativeException, result));
        
        }

        private static bool CheckGreaterThanThousand(int n)
        {
            return n > 1000;
        }
    }
}
