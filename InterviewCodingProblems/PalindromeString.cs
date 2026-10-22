using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class PalindromeString
    {
        // Check if a string is a palindrome
        public bool IsPalindrome(string s)
        {
            if (s == null) return false;
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        //using LINQ
        public bool IsPalindromeWithLinq(string s)
        {
            if (s == null) return false;
            string reversed = new string(s.Reverse().ToArray());
            return s.Equals(reversed, StringComparison.Ordinal);
        }

        //using Built-in functions
        public bool IsPalindromeWithBuiltIn(string s)
        {
            if (s == null) return false;
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            return s.Equals(reversed, StringComparison.Ordinal);
        }
    }
}
