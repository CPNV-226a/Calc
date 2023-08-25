namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********INPUT*****************");
            Console.Write("Enter the first operande : ");
            string op1 = Console.ReadLine();
            Console.WriteLine("First operande detected : " + op1);

            Console.Write("Enter the operator : ");
            string oper = Console.ReadLine();
            Console.WriteLine("Operator detected : " + oper);

            Console.Write("Enter the second operande : ");
            string op2 = Console.ReadLine();
            Console.WriteLine("Second operande detected : " + op2);
            Console.WriteLine();

            Console.WriteLine("**********RESULT*****************");
            int result = int.Parse(op1) + int.Parse(op2);
            Console.WriteLine("Calculation is " + op1 + oper + op2 + " = " + result);
            Console.WriteLine("*********************************");
        }
    }
}