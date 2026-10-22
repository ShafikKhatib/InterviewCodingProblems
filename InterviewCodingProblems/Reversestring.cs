using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class Reversestring
    {
        //Using built-in functions
        public string ReverseString(string s)
        {
            if (s == null) return null;
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //Without using built-in functions
        public string ReverseStringWithoutBuiltIn(string s)
        {
            if (s == null) return null;
            char[] charArray = s.ToCharArray();
            int left = 0;
            int right = charArray.Length - 1;
            while (left < right)
            {
                // Swap characters
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
                left++;
                right--;
            }
            return new string(charArray);
        }

        //using StringBuilder
        public string ReverseStringWithStringBuilder(string s)
        {
            if (s == null) return null;
            StringBuilder reversed = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed.Append(s[i]);
            }
            return reversed.ToString();
        }

        //Using LINQ
        public string ReverseStringWithLinq(string s)
        {
            if (s == null) return null;
            return new string(s.Reverse().ToArray());
        }

    }
}
