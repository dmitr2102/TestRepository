namespace MathCalculatorTests 
{
    public class MathCalculator
    {
        public int SumS(string a, string b)
        {
            return(Int(a) + Int(b));
        }
        public int SumI(string a, string b)
        {
            return(Int(a) + Int(b));
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}