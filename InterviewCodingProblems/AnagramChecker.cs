using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class AnagramChecker
    {
        public AnagramChecker() { }

        //Using Sorting
        public static bool Anagram1(string s1, string s2)
        {
            if(s1.Length !.Equals(s2)) 
                return false;

            char[] arr1 = s1.ToLower().ToCharArray();
            char[] arr2 = s2.ToLower().ToCharArray();

            Array.Sort(arr1, arr2);


            return arr1.SequenceEqual(arr2);
        }

        
    }
}
