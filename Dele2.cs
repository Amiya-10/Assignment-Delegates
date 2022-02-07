using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    class Dele2
    {
        delegate int MyDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            MyDelegate arOperation = (int num1, int num2) => num1 + num2;
            PerformArithmeticOperation(1, 2, arOperation);
            Console.ReadKey();
        }
        static void PerformArithmeticOperation(int n1, int n2, MyDelegate arOperation)
        {
            var result = arOperation(n1, n2);
            Console.WriteLine(result);
        }
    }
}
