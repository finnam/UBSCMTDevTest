using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UBSCMTDevTest
{
    public class AFWordFrequencyAnalyzer : IWordFrequencyAnalyzer
    {
        public static IWordFrequencyAnalyzer GetWordFrequencyAnalyzer()
        {
            return new AFWordFrequencyAnalyzer();
        }

        private AFWordFrequencyAnalyzer()
        {

        }

        public string GetWords(string text)
        {
            if (text==null)
            {
                throw new ArgumentException("text must not be null");
            }

            StringBuilder sb = new StringBuilder();
            foreach(var w in GetWordsImpl(text))
            {
                sb.Append(w.ToString());
                sb.Append('\n');
            }
            return sb.ToString();
        }
        private IList<IWordFrequency> GetWordsImpl(string text)
        {
            Regex exp = new Regex(@"[A-Za-z]", RegexOptions.None);
            MatchCollection matches = Regex.Matches(text, @"[A-Za-z]+");

            IDictionary<string, int> words = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
            foreach (Match nextMatch in matches)
            {
                string w = nextMatch.ToString().ToLower();
                if (words.ContainsKey(w))
                {
                    words[w]++;
                }
                else
                {
                    words.Add(w,1);
                }
            }
            return words.Select(w => (IWordFrequency)new AFWordFrequency(w.Key, w.Value)).ToList();

        }
    }
}
