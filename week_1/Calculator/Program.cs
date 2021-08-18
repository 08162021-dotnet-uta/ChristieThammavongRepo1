using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
          // input stuff
          var input1 = int.Parse(Console.ReadLine()); //type inference, parsing
          var input2 = int.Parse(Console.ReadLine());
          
          // compute stuff
          int result1 = Add(input1, input2);
          int result2 = Subtract(input1, input2);
          int result3 = Multiply(input1, input2);
          int result4 = Divide(input1, input2);

          // output stuff
          Print(result1, result2, result3, result4);
        }

        static int Add(int input1, int input2)
        {
          // compute stuff
          return input1 + input2; //type inference, casting

        }

        static int Subtract(int input1, int input2)
        {
          // compute stuff
          return input1 - input2; //type inference, casting
        }

        static int Multiply(int input1, int input2)
        {
          // compute stuff
          return input1 * input2; //type inference, casting
        }

        static int Divide(int input1, int input2)
        {
          // compute stuff
          return input1 / input2; //type inference, casting
        }

        static void Print(params int[] results)
        {
          // output stuff
          for (int i = 0; i < results.Length; i++) {
            Console.WriteLine(results[i]);
          }
        }
    }
}
