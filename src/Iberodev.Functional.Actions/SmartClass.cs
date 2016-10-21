using System;

namespace Iberodev.Functional.Action
{
    public class SmartClass
    {
        public void Divide(int numerator, int denominator, Action<string> methodAddress)
        {
            if (denominator == 0)
            {
                methodAddress?.Invoke("Cannot divide by zero");
            }
            else
            {
                int result = numerator / denominator;
                methodAddress?.Invoke($"The result is {result}");
            }
        }
    }
}
