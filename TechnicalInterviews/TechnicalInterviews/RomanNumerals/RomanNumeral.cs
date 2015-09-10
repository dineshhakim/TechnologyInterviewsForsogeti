using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalInterviews.RomanNumerals
{
    public class RomanNumeral
    {
        private static readonly int[] VALUES = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static readonly String[] SYMBOLS = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        private static readonly List<TextValue> RomanArabic = new List<TextValue>{
                                                                    new TextValue("M", 1000),
                                                                    new TextValue("CM", 900),
                                                                    new TextValue("D", 500),
                                                                    new TextValue("CD", 400),
                                                                    new TextValue("C", 100),
                                                                    new TextValue("XC", 90),
                                                                     new TextValue("L", 50),
                                                                   new TextValue("XL", 40),
                                                                   new TextValue("X", 10),
                                                                   new TextValue("IX", 9),
                                                                   new TextValue("V", 5),
                                                                   new TextValue("IV", 4),
                                                                   new TextValue("I", 1)
                                                                };

        //public RomanNumeral()
        //{
        //    RomanArabic.Add(new TextValue("M", 1000));
        //    RomanArabic.Add(new TextValue("CM", 900));
        //    RomanArabic.Add(new TextValue("D", 500));
        //    RomanArabic.Add(new TextValue("CD", 400));
        //    RomanArabic.Add(new TextValue("C", 100));
        //    RomanArabic.Add(new TextValue("XC", 90));
        //    RomanArabic.Add(new TextValue("L", 50));
        //    RomanArabic.Add(new TextValue("XL", 40));
        //    RomanArabic.Add(new TextValue("X", 10));
        //    RomanArabic.Add(new TextValue("IX", 9));
        //    RomanArabic.Add(new TextValue("V", 5));
        //    RomanArabic.Add(new TextValue("IV", 4));
        //    RomanArabic.Add(new TextValue("I", 1));

        //}
        public static string ArabicToRoman(int arabic)
        {
            StringBuilder result = new StringBuilder();
            int remaining = arabic;
            //for (int i = 0; i < VALUES.Length; i++)
            //{
            //    remaining = AppendRomanNumerals(remaining, VALUES[i], SYMBOLS[i], result);
            //}
            foreach (var ra in RomanArabic)
            {
                remaining = AppendRomanNumerals(remaining, ra.Value, ra.Text, result);
            }
            return result.ToString();
        }
        private static int AppendRomanNumerals(int arabic, int value, String romanDigits, StringBuilder builder)
        {
            int result = arabic;
            while (result >= value)
            {
                builder.Append(romanDigits);
                result -= value;
            }
            return result;
        }

        public static int RomanToArabic(string roman)
        {
            int result = 0;
            string remaining = roman;
           
            foreach (var ra in RomanArabic)
            {
                
            }
            return result;
        }
        private static string AppendArabicNumerals(string roman, int value, String romanDigits, int res)
        {
            string result = roman;
            while (result.Substring(1, 1) != "")
            {
                //builder.Append(romanDigits);
                res += value;
                result = roman.PadRight(1);
            }
            return result;
        }
    }
}
