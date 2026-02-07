using System;
using System.Diagnostics;

namespace HelloWorld
{
    class Programa
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string FinalResult = "Result:";
            string num1 = string.Empty;
            string num2 = string.Empty;
            string typeOp = string.Empty;
            
            Console.WriteLine("-------------- Welcome to my Calculator --------------- ");
            Console.WriteLine("1.sum");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Adiction");
            Console.WriteLine("4.Multiplication");
            Console.WriteLine("--------------Digite sua operação--------------------");
            typeOp = Console.ReadLine();
            
            if (typeOp == "1")
            {
                Console.WriteLine("--------------Soma---------------");
                Console.WriteLine(" Digite o primeiro numero para somar");
                num1 = Console.ReadLine();
                Console.WriteLine("Digite o segundo digito para somar");
                num2 = Console.ReadLine();

                for (int x = 0; x < numbers.Length; x++) //percurr array of numbers
                {
                    if (x == numbers[x])
                    {
                        
                    }
                }

            }
        
        }
    }

}