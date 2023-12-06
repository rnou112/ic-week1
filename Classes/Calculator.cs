

namespace SoftwareDev_Week1.Classes
{
    internal class Calculator : AbstractBase
    {
        public override int Add(int a, int b)
        {
            return a + b;
        }

        public override int Subtract(int a, int b)
        {
            return a - b;
        }

        public override int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
