using System;
using System.Collections.Generic;

namespace Iberodev.Functional.Func
{
    public class SmartClass
    {
        public IEnumerable<string> ConvertToListOfUpperCaseWords(string sentence)
        {
            return sentence.ToUpper().Split(' ');
        }
    }
}
