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
            //you could assign the same method again and it will execute the method twice
            //smartClass.MethodAddress += WriteInConsole;
            smartClass.MethodAddress += SendByEmail;
            smartClass.Divide(6, 0);
            Console.ReadLine();
        }
        private void WriteInConsole(string message)
        {
            Console.WriteLine(message);
        }

        private void SendByEmail(string message)
        {
            //this could be sending the message by email
        }
    }
}
