namespace Calculator
{
    public class MathLib
    {
        public float Calculate(float op1, char oper, float op2)
        {
            switch (oper)
            {
                case '+':
                    return op1 + op2;
                case '-':
                    return op1 - op2;
                case '*':
                    return op1 * op2;
                case '/':
                    return op1 / op2;
                default:
                    throw new BadOperatorException();
            }
        }
        public class CalcException : Exception { };
        public class BadOperatorException : CalcException { };
    }
}
