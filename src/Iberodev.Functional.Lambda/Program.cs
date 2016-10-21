using Iberodev.Functional.Lambda;
using System;

namespace IberodevFuncionalProgramming
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
            smartClass.MethodAddress += message => Console.WriteLine($"Using lambda the result is \n{message}");
            smartClass.Divide(6, 0);
            Console.ReadLine();
        }
    }
}
