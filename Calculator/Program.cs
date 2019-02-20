using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double Num1, Num2, Result = 0;
            char Operation;

            Console.WriteLine(" Insert a Operation:--> ");
            Console.WriteLine("+  Sum ----------------->");
            Console.WriteLine("-  Subtraction --------->");
            Console.WriteLine(" * Multiplication-------->");
            Console.WriteLine(" / Division -------------->");

            Console.WriteLine();

            Console.WriteLine("Operation:  ");

            char.TryParse(Console.ReadLine(), out Operation);

            Console.WriteLine();
            Console.WriteLine("Inform the first value");
            double.TryParse(Console.ReadLine(), out Num1);

            Console.WriteLine();
            Console.WriteLine("Inform the second value");
            double.TryParse(Console.ReadLine(), out Num2);

            Console.WriteLine();
            Console.WriteLine();

            switch (Operation)
            {
                case '+':
                    Result = Sum(Num1, Num2);
                    break;

                case '-':
                    Result = Subtraction(Num1, Num2);
                    break;

                case'*':
                    Result = Multiplication(Num1, Num2);
                    break;

                case'/':
                    Result = Division(Num1, Num2);
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(String.Format("Result: {0}", Result));

            Console.ReadKey();

            }
        private static Double Sum(double Num1, double Num2)
        {
            return (Num1 + Num2);
        }
        private static Double Subtraction(double Num1, double Num2)
        {
            return (Num1 - Num2);
        }
        private static Double Multiplication(double Num1, double Num2)
        {
            return (Num1 * Num2);
        }
        private static Double Division(double Num1, double Num2)
        {
            return (Num1 / Num2);
        }
        }
    }

