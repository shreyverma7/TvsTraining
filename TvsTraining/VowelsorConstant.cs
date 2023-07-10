using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    internal class VowelsorConstant
    {
            public void isVowelorConstant()
        {
            Console.WriteLine("Enter any character: ");
            char a = Convert.ToChar(Console.ReadLine());

            if(a == 'a'|| a == 'e' || a == 'i' || a == 'o' ||  a == 'u' || a == 'A' || a == 'I' || a == 'O' || a == 'E' || a == 'U' ) {
                Console.WriteLine(a + "is an vowel");

            }else
            {
                Console.WriteLine(a+ " is a constant");
            }

        }
    }
}
