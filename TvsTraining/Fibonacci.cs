using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    internal class Fibonacci
    {
        public  void uptoFibonacci() 
        {
            Console.WriteLine("Enter the number upto :");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 =0, n2 =1 ,n3,i;  //Taking 0 and 1 as starting number
            Console.Write(n1 +" "+n2);
            for (i=2;i<num;i++)
            {
                n3 = n1 + n2;
                Console.Write(" "+n3);
                n1= n2;
                n2 = n3;
            }

        }
    }
}
