using System;

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
            smartClass.OnPrimeFound += WritePrimeNumber;
            var totalPrimeNumbers = smartClass.GetTotalPrimeNumbers(1, 20);
            Console.WriteLine($"Total Prime Numbers: {totalPrimeNumbers}");
            Console.ReadLine();
        }

        private void WritePrimeNumber(object sender, PrimeNumberEventArgs e)
        {
            Console.WriteLine($"{sender} informs: Prime number found = {e.PrimeNumber}");
        }
    }
}
