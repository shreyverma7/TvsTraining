using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  TvsTraining
{
    internal class Factorial
    {
        public void isFactorial() {
            Console.WriteLine("Enter a number to See factorial : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for(int i = 1; i <= num; i++) { 
               sum = sum * i;
            }
            Console.WriteLine("The factorial is " + sum);
        }
    }
}
