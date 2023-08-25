namespace Calculator
{
    public static class MathLib
    {
        public static float Add(float op1, float op2)
        {
            return op1 + op2;
        }

        public static float Sub(float op1, float op2)
        {
            return op1 - op2;
        }

        public static float Mul(float op1, float op2) 
        {
            return op1 * op2;
        }

        public static float Div(float op1, float op2)
        {
            return op1 / op2;
        }

        public class CalcException : Exception { };
        public class BadOperatorException : CalcException { };
    }
}
