using System;
using System.Diagnostics;

namespace HelloWorld
{
    class Programa
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string resposta = "Resultado:";
            string num1 = string.Empty;
            string num2 = string.Empty;
            string typeOp = string.Empty;
            
            Console.WriteLine("--------------Bem vindo a calculadora --------------- ");
            Console.WriteLine("1.Soma");
            Console.WriteLine("2.Subtração");
            Console.WriteLine("3.Adição");
            Console.WriteLine("4.Multiplicação");
            Console.WriteLine("--------------Digite sua operação--------------------");
            typeOp = Console.ReadLine();
            
            if (typeOp == "1")
            {
                Console.WriteLine("--------------Soma---------------");
                Console.WriteLine(" Digite o primeiro numero para somar");
                num1 = Console.ReadLine();
                Console.WriteLine("Digite o segundo digito para somar");
                num2 = Console.ReadLine();

                for (int x = 0; x < numbers.Length; x++) //percorre array numbers 
                {
                    if (x == numbers[x])
                    {
                        
                    }
                }

                //Console.WriteLine(resposta +);
            }
        
        }
    }

}