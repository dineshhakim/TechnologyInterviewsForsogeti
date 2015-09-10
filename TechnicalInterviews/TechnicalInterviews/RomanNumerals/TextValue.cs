using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalInterviews.RomanNumerals
{
    public class TextValue
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public TextValue(string text, int value)
        {
            Text = text;
            Value = value;

        }       
    }
}
