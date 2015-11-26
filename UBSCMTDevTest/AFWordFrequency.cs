using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UBSCMTDevTest
{
    public static class AFWordFrequencyExtension
    {
        public static string ToString(this List<IWordFrequency> words)
        {
            return String.Join(",",words);
        }
    }
    public class AFWordFrequency : IWordFrequency
    {
        private string _word;
        private int _freq;

        public AFWordFrequency(string word, int frequency)
        {
            this._word = word;
            this._freq = frequency;
        }

        public string Word 
        {
            get
            {
                return _word;
            }
         }
        public int Frequency 
        {
            get
            {
                return _freq;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}-{1}", Word, Frequency);
        }
    }
}
