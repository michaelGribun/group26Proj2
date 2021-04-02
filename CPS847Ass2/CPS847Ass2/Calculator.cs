using System;

namespace CPS847Ass2
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            try
            {
                string oper = "";
                double num1 = 0;
                double num2 = 0;
                double res = 0;
                if (args.Length == 3)
                {
                    num1 = double.Parse(args[0]);
                    num2 = double.Parse(args[1]);
                    oper = args[2];
                }
                else
                {
                    Console.WriteLine("You need three arguments to run this program");
                }
                if (oper == "add")
                {
                    res = addThem(num1, num2);
                }
                else if (oper == "subtract")
                {
                    res = subtractThem(num1, num2);
                }
                else if (oper == "multiply")
                {
                    res = multiplyThem(num1, num2);
                }
                else if (oper == "divide")
                {
                    res = divideThem(num1, num2);
                }
                Console.WriteLine("The answer to your operation was: " + res);


            }
            catch (Exception e)
            {
                Console.WriteLine("Something was wrong with your input. Here's the stack trace: " + e.ToString());
            }

        }

        public static double addThem(double a, double b)
        {
            Console.WriteLine("Adding...");
            return a + b;
        }

        public static double subtractThem(double a, double b)
        {
            Console.WriteLine("Subtracting...");
            return a - b;
        }

        public static double multiplyThem(double a, double b)
        {
            Console.WriteLine("Multiplying...");
            return a * b;
        }

        public static double divideThem(double a, double b)
        {
            Console.WriteLine("Dividing...");
            if (b != 0) return a / b;
            else
            {
                Console.WriteLine("Can't divide by 0... returning 0");
                return 0;
            }
        }
    }
}
