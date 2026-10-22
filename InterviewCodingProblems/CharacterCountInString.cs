using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class CharacterCountInString
    {
        // Count occurrences of each character in a string  
        public CharacterCountInString(string name) { 
            
        }

        //using Dictionary
        public Dictionary<char, int> CountCharacters(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            return charCount;
        }

        //using LINQ
        public Dictionary<char, int> CountCharactersWithLinq(string s)
        {
            return s.GroupBy(c => c)
                    .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
