using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace HelloWorld
{
    class Programa
    {
        static void Main(string[] args)
        {
            string FinalResult = "The Result of the sum is : "; 
            string typeOp = string.Empty;

            Console.WriteLine("-------------- Welcome to my Calculator --------------- ");
            Console.WriteLine("1.sum");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Adiction");
            Console.WriteLine("4.Multiplication");
            Console.WriteLine("-------------- Type the operation --------------------");
            typeOp = Console.ReadLine();
            
            if (typeOp == "1")
            {
                Console.WriteLine(FinalResult += Programa.sum("1"));
            }
            else if (typeOp == "2")
            {
                Console.WriteLine(FinalResult += Programa.sub("2");
            }
            
        
        }

        static string sum(string strings)
        {
            int num1;
            int num2;
            string finalResult;

            Console.WriteLine("--------------Sum---------------");
            Console.WriteLine("Type the first number to sum");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number to sum");
            num2 = int.Parse(Console.ReadLine());

            finalResult = ((num1 + num2).ToString());

            return finalResult;

        }

        static string sub(string strings) {
            int num1;
            int num2;
            string finalResult;

            Console.WriteLine("---------Substraction-------");
            Console.WriteLine("Type the first number to sub");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            finalResult = ((num1 + num2).ToString());

            return finalResult;
        } 
    }

}