using System;

namespace HelloCsharp
{
    class Program
    {
        // Build a simple calculator using 5 methods: Add, Multiply, Subtract, Divide, Print
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number1;
            int number2;
            Console.WriteLine("Enter two numbers with a space in between:");
            String input = Console.ReadLine();
            number1 = Convert.ToInt32(input.Split(' ')[0]);
            number2 = Convert.ToInt32(input.Split(' ')[1]);
            Program program = new Program();
            program.print(number1, number2);
        }

        public int add(int num1, int num2) {
            return num1 + num2;
        }

        public int multiply(int num1, int num2) {
          return num1 * num2;
        }

        public int subtract(int num1, int num2) {
            return num1 - num2;
        }

        public int divide(int num1, int num2) {
            if (num2 == 0) {
              return -1;
            } else {
              return num1 / num2;
            }
        }

        public void print(int num1, int num2) {
            Console.WriteLine("Addition: " + add(num1, num2));
            Console.WriteLine("Multiplication: " + multiply(num1, num2));
            Console.WriteLine("Subtraction: " + subtract(num1, num2));
            Console.WriteLine("Division: " + divide(num1, num2));
        }
    }
}
