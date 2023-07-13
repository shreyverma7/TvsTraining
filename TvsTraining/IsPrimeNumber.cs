using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvsTraining
{
    internal class IsPrimeNumber
    {
        public void CheckNumberIsPrime()
        {
            int count = 0;
            //input
            Console.WriteLine("Enter number - ");
            int input = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < input; i++)
            {
                if(input % i == 0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                Console.WriteLine("Prime Number ");
            }
            else
            {
                Console.WriteLine(" Not a prime Number ");
            }
        }
    }
}
