using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBSCMTDevTest
{
    public interface IWordFrequencyAnalyzer
    {
        string GetWords(string text);
    }
}
