namespace UnitTest_HW
{
    public class Calculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by zero");
            }

            return a / b;
        }
    }
}
