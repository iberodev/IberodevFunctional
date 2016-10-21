namespace Iberodev.Functional.Delegate
{
    public delegate void WriteMessage(string message);

    public class SmartClass
    {
        public WriteMessage MethodAddress { get; set; }
        public void Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                MethodAddress?.Invoke("Cannot divide by zero");
            }
            else
            {
                int result = numerator / denominator;
                MethodAddress?.Invoke($"The result is {result}");
            }
        }
    }
}
