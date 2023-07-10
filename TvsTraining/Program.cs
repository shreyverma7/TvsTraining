using System;

namespace Operation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           // Addition.Sub();                       // This is how static method is called
           //  Addition addition = new Addition();  // This is how non-static method is called (using object)
           // addition.Add();

           // IsPrimeNumber primeNumber = new IsPrimeNumber();
           // primeNumber.CheckNumberIsPrime();

           //  OddorEven oddorEven = new OddorEven();
           // oddorEven.checkOddorEven();

           // Factorial factorial = new Factorial();
           // factorial.isFactorial();

          //  Fibonacci fibonacci = new Fibonacci();
           // fibonacci.uptoFibonacci();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter input : \n 1 : Factorial \n 2 : Fibonacci \n 3 : Odd or even \n 4 : Prime Number \n 5 : addition \n 6 : subtraction \n 7 : quit \n 8 : Tables \n 9 : Swap without variable \n10 : Vowels or Constant");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1: Factorial factorial = new Factorial();
                           factorial.isFactorial();
                        break;
                    case 2:
                        Fibonacci fibonacci = new Fibonacci();
                        fibonacci.uptoFibonacci();
                        break;
                     case 3:
                        OddorEven oddorEven = new OddorEven();
                         oddorEven.checkOddorEven();
                        break;
                    case 4:
                        IsPrimeNumber primeNumber = new IsPrimeNumber();
                        primeNumber.CheckNumberIsPrime();
                        break;
                     case 5:
                        Addition addition = new Addition();  
                        addition.Add();
                        break;
                     case 6:
                        Addition.Sub();
                        break;
                     case 7:
                        flag = false; 
                        break;
                     case 8:
                        Tables tables = new Tables();
                        tables.TogetTable();
                        break;
                    case 9:
                        SwapNumber swapNumber = new SwapNumber();
                        swapNumber.ToSwapNumber();
                        break;
                     case 10:
                        VowelsorConstant voc = new VowelsorConstant();
                        voc.isVowelorConstant();
                        break;
                      default:
                        Console.WriteLine("Invalid input");
                        break;

                        
                }
                Console.WriteLine("\n");
            }

        }
    }
}