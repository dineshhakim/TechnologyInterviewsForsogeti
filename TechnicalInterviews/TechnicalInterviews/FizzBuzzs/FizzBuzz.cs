namespace TechnicalInterviews.FizzBuzzs
{
    public class FizzBuzz
    {
        public static string FIZZ = "fizz";

        public static string BUZZ = "buzz";
        public static string POP = "pop";
        // public static string FIZZBUZZ = "fizz buzz";
        public static int FIZZNUMBER = 3;
        public static int BUZZNUMBER = 5;
        public static int POPNUMBER = 7;
        public static string GetFizzBuzzUpto(int n)
        {
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                result = result + " " + CheckFizzBuzz(i);
            }
            return result;
        }

        public static string CheckFizzBuzz(int n)
        {
            string result = string.Empty;
            if (IsFizz(n))
            {
                result = result + FIZZ;
            }
            if (IsBuzz(n))
            {
                result = result + BUZZ;
            }
            if (IsPop(n))
            {
                result = result + POP;
            }
            if (result == string.Empty)
            {
                result = n.ToString();
            }
            return result;
        }

        private static bool IsFizz(int no)
        {
            return no % FIZZNUMBER == 0;
        }
        private static bool IsBuzz(int no)
        {
            return no % BUZZNUMBER == 0;
        }
        private static bool IsPop(int no)
        {
            return no % POPNUMBER == 0;
        }
    }
}
