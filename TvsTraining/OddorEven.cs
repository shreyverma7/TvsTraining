using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    internal class OddorEven
    {
        public  void  checkOddorEven() {
            Console.WriteLine("Enter a number to Check odd or even :");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine(num + " Is Even number ");
            }
            else
            {
                Console.WriteLine(num + " Is Odd number ");
            }
        }
    }
}
