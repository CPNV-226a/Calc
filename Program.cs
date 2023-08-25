namespace Calculator
{
    internal class Program
    {
        static private float op1;
        static private char oper;
        static private float op2;
        static private float result;

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("***********INPUT*****************");
                Console.Write("Enter the first operande : ");
                op1 = int.Parse(Console.ReadLine());
                Console.WriteLine("First operande detected : " + op1);

                Console.Write("Enter the operator : ");
                oper = char.Parse(Console.ReadLine());
                Console.WriteLine("Operator detected : " + oper);

                Console.Write("Enter the second operande : ");
                op2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Second operande detected : " + op2);
                Console.WriteLine();

                Console.WriteLine("**********RESULT*****************");
                try
                {
                    result = Calculate(op1, oper, op2);
                }
                catch (NotImplementedException ex)
                {
                    Console.Write("This operator doesn't exist !");
                }
                Console.Clear();
                Console.WriteLine("Calculation is " + op1 + oper + op2 + " = " + result);
            }
        }

        private static float Calculate(float op1, char oper, float op2)
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
                    throw new NotImplementedException();
               }
        }
    }
}