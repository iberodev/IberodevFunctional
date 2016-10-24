using Iberodev.Functional.Func;
using System;
using System.Collections.Generic;

namespace Iberodev.Functional.Func
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DelegateExamples example = new DelegateExamples();
            example.RunExampleDelegate();
        }
    }

    public class DelegateExamples
    {
        public void RunExampleDelegate()
        {
            SmartClass smartClass = new SmartClass();
            PrintWordsOnConsole("I like learning Func with Iberodev", smartClass.ConvertToListOfUpperCaseWords);
            PrintWordsOnConsole("Hey! and now I understand delegates!", (sentence) =>
            {
                return sentence.ToLower().Split('!');
            });
            Console.ReadLine();
        }

        private void PrintWordsOnConsole(string sentence, Func<string, IEnumerable<string>> functionThatReturnsWords)
        {
            var words = functionThatReturnsWords(sentence);
            foreach(var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
