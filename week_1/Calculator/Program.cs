using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
          // input stuff
          // int input1, input2;
          if(Input(out int input1, out int input2))
          {
            // compute stuff
            int result1 = Add(input1, input2);
            int result2 = Subtract(input1, input2);
            int result3 = Multiply(input1, input2);
            int result4 = Divide(input1, input2);

            // output stuff
            Print(result1, result2, result3, result4);
          }
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
          if (input2 == 0) {
            return -1;
          } else {
          // compute stuff
            return input1 / input2; //type inference, casting
          }
        }

        static void Print(params int[] results)
        {
          // output stuff
          /*
          for (int i = 0; i < results.Length; i++) {
            Console.WriteLine(results[i]);
          }
          */
          foreach (var result in results) // C# specific, works better than for loop
          {
              Console.WriteLine(result);
          }
        }

        static bool CustomTryParse(string s, out int result) // TryParse behind-the-scenes
        {
          try
          {
            result = int.Parse(s);
            return true;
          }
          catch
          {
            result = 0;
            return false;
          }
        }

        static bool Input(out int i1, out int i2)
        {
          // input stuff
          int input1, input2;

          if (int.TryParse(Console.ReadLine(), out input1) && int.TryParse(Console.ReadLine(), out input2))
          {
            i1 = input1;
            i2 = input2;

            return true;
          }
          else
          {
            i1 = i2 = 0;

            return false;
          }
          
          // try
          // {
          //   var input1 = int.Parse(Console.ReadLine()); //type inference, parsing
          //   var input2 = int.Parse(Console.ReadLine());
          // }
          // catch(Exception ex)
          // {
          //   //throw ex; // points to the original error
          //   throw new Exception(" ", ex); // create a new error
          // }
          // finally
          // {
          //   // always run
          // }
        }
    }
}
