using System.Diagnostics;
using static Calculator.MathLib;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***********INPUT*****************");
                Console.Write("Enter the first operande : ");
                float op1 = float.Parse(Console.ReadLine());
                Console.WriteLine("First operande detected : " + op1);

                Console.Write("Enter the operator : ");
                char oper = char.Parse(Console.ReadLine());
                Console.WriteLine("Operator detected : " + oper);

                Console.Write("Enter the second operande : ");
                float op2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Second operande detected : " + op2);
                Console.WriteLine();

                Console.Clear();
                Console.WriteLine("**********RESULT*****************");

                try
                {
                    MathRequest mathRequest = new MathRequest(op1, oper, op2);
                    mathRequest.Result = Calculate(mathRequest);
                    Console.WriteLine(mathRequest.ToString());
                }
                catch (MathLib.BadOperatorException ex)
                {
                    Console.WriteLine("This operator " + oper + " doesn't exist !");
                }
            }
        }
        private static float Calculate(MathRequest mathRequest)
        {
            switch (mathRequest.Ope())
            {
                case '+':
                    return MathLib.Add(mathRequest);
                case '-':
                    return MathLib.Sub(mathRequest);
                case '*':
                    return MathLib.Mul(mathRequest);
                case '/':
                    return MathLib.Div(mathRequest);
                default:
                    throw new BadOperatorException();
            }
        }
    }
}