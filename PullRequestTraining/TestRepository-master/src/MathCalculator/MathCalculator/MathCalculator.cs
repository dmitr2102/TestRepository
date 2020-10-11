namespace MathCalculatorTests 
{
    public class MathCalculator
    {
        public int Sum(string a, string b)
        {
            return(Int(a) + Int(b));
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}