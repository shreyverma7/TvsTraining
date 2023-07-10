using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    internal class Tables
    {
        public void TogetTable() 
        {
            Console.WriteLine("Enter any number to get Tables : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(num +" * "+i+" = "+ i*num);
                Console.WriteLine("\n");

            }


        }
    }
}
