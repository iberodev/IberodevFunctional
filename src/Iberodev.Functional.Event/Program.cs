using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iberodev.Functional.Event
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EventExamples example = new EventExamples();
            example.RunEventSample();
        }
    }

    public class EventExamples
    {
        public void RunEventSample()
        {
            SmartClass smartClass = new SmartClass();
            //var totalPrimeNumbers = smartClass.GetTotalPrimeNumbers(1, 200, WritePrimeNumberFound);
            var totalPrimeNumbers = smartClass.GetTotalPrimeNumbers(1, 200, primeNumber => {
                Console.WriteLine($"Prime number found = {primeNumber}");
            });
            Console.WriteLine($"Total Prime Numbers: {totalPrimeNumbers}");
            Console.ReadLine();
        }

        //private void WritePrimeNumberFound(int primeNumber)
        //{
        //    Console.WriteLine($"Prime number found = {primeNumber}");
        //}
    }
}
