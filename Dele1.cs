using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    class Dele1
    {
        private delegate double Operation(double num1, double num2);
        static void Main(string[] args)
        {
            Console.Write("Input number 1: ");
            var num1 = double.Parse(Console.ReadLine());
            Console.Write("Input number 2: ");
            var num2 = double.Parse(Console.ReadLine());
            Console.Write("Input operation (+,*,/,- or max): ");
            var option = Console.ReadLine().Trim();
            Operation operation;
            switch(option)
            {
                case "+":
                    operation = ArithmeticOperations.Add;
                    break;
                case "*":
                    operation = ArithmeticOperations.Multiply;
                    break;
                case "/":
                    operation = ArithmeticOperations.Divide;
                    break;
                case "-":
                    operation = ArithmeticOperations.Substract;
                    break;
                case "max":
                    operation = ArithmeticOperations.Max;
                    break;
                default:
                    Console.WriteLine("Error!!");
                    return;
            }
            var result = operation(num1, num2);
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
    public class ArithmeticOperations
    {
        public static double Add(double num1, double num2) => num1 + num2;
        public static double Multiply(double num1, double num2) => num1 * num2;
        public static double Divide(double num1, double num2) => num1 / num2;
        public static double Substract(double num1, double num2) => num1 - num2;
        public static double Max(double num1, double num2) => num1 >= num2 ? num1 : num2;
    }
}
