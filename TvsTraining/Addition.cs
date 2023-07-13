using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvsTraining
{
    internal class Addition
    {
        public void Add()
        {
            Console.WriteLine("Enter a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Addition : " + c);
        }
        public static void Sub()
        {
            Console.WriteLine("Enter a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a - b;
            Console.WriteLine("Subtraction : " + c);
        }
    }
}
