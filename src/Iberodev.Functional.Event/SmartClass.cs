using System;

namespace Iberodev.Functional.Event
{
    public delegate void PrimeFoundEventHandler(object sender, PrimeNumberEventArgs e);

public class PrimeNumberEventArgs : EventArgs
{
    public int PrimeNumber { get; set; }
}

    public class SmartClass
    {
        public event PrimeFoundEventHandler OnPrimeFound;

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

        public int GetTotalPrimeNumbers(int fromNumber, int toNumber)
        {
            int count = 0;
            for(int i = fromNumber; i <= toNumber; i++)
            {
                if (IsPrimeNumber(i))
                {
                    count++;
                    OnPrimeFound?.Invoke(this, new PrimeNumberEventArgs {
                        PrimeNumber = i
                    });
                }
            }
            return count;
        }
    }
}
