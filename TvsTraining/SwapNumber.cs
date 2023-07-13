using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvsTraining
{
    internal class SwapNumber
    {
        public  void ToSwapNumber()
        {
            Console.WriteLine("swap number" );
            Console.WriteLine("Enter 1st number : ");
            int a = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Enter 1st number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            
            a = a+b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Now after swapping a is " + a + " & b is " + b);
        }
    }
}
