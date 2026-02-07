using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            string typeOperation = string.Empty;

            Console.WriteLine("-------------- Welcome to my Calculator --------------- ");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.division");
            Console.WriteLine("4.Multiplication");
            Console.WriteLine("-------------- Type the operation --------------------");
            typeOperation = Console.ReadLine();

            if (typeOperation == "1")
            {
                Console.WriteLine("The final result:" + Program.Addition().ToString());
            }
            else if (typeOperation == "2")
            {
                Console.WriteLine("The final result:" +  Program.Subtraction().ToString());
            }
            else if (typeOperation == "3")
            {
                Program.Division();
            }
            else if (typeOperation == "4")
            {
                Console.WriteLine("The final result:" +  Program.Multiplication().ToString());
            }else
            {
                Console.WriteLine("The operation not is valid");
            }
          
        }
        static int Addition()
        {

            int FirstNumber = 0;
            int SecondNumber = 0;
            int Result = 0;

            Console.WriteLine("--------------Addition---------------");
            Console.WriteLine("Type the first number to Addition");
            FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number to Addition");
            SecondNumber = int.Parse(Console.ReadLine());

            Result = (FirstNumber + SecondNumber);

            return Result;

        }

        static int Subtraction() {

            int FirstNumber = 0;
            int SecondNumber = 0;
            int Result = 0;

            Console.WriteLine("---------Subtraction-------");
            Console.WriteLine("Type the first number to sub");
            FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number to sub");
            SecondNumber = int.Parse(Console.ReadLine());
            Result = (FirstNumber - SecondNumber);

            return Result;
        }
        static void Division()
        {
            double Result;

            Console.WriteLine("---------Division-------");
            Console.WriteLine("Type the first number to the division");
            if (!double.TryParse(Console.ReadLine(), out double FirstNumber)) return ;
            Console.WriteLine("Type the second number to the division");
            if (!double.TryParse(Console.ReadLine(), out double  SecondNumber)) return ;
            
            if (SecondNumber == 0)
            {
                Console.WriteLine("Numer can't calculate by zero");
            }else
            {
                Console.WriteLine($"The final result:{FirstNumber / SecondNumber}");
            }
   
        }
        static int Multiplication()
        {

            int FirstNumber = 0;
            int SecondNumber = 0;
            int Result = 0;

            Console.WriteLine("---------Multiplication-------");
            Console.WriteLine("Type the first number to Mult");
            FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number to Mult");
            SecondNumber = int.Parse(Console.ReadLine());
            Result = (FirstNumber * SecondNumber);

            return Result;
        }
    }

}