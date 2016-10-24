using System;
using System.Collections.Generic;

namespace Iberodev.Functional.Event
{
    public class SmartClass
    {
        public delegate void WritePrimeFound(int primeNumber);

        public bool IsPrimeNumber(int number)
        {
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                var remain = number % i;
                if (remain == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }

        public int GetTotalPrimeNumbers(int fromNumber, int toNumber, WritePrimeFound writePrimeFound)
        {
            int count = 0;
            for(int i = fromNumber; i <= toNumber; i++)
            {
                if (IsPrimeNumber(i))
                {
                    count++;
                    // notify if anybody subscribed
                    if (writePrimeFound != null)
                    {
                        writePrimeFound.Invoke(i);
                    }
                }
            }
            return count;
        }
    }
}
