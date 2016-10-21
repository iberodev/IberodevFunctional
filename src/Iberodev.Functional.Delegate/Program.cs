using Iberodev.Functional.Delegate;
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
            smartClass.MethodAddress += WriteInConsole;
            smartClass.MethodAddress += delegate (string message)
                                        {
                                            Console.WriteLine("Inside an anonymous function:");
                                            Console.WriteLine(message);
                                        };
            smartClass.Divide(6, 0);
            Console.ReadLine();
        }
        private void WriteInConsole(string message)
        {
            Console.WriteLine("Inside WriteInConsole method:");
            Console.WriteLine(message);
        }
    }
}
