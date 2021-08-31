using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");
        }

        public static string GetName()
        {
            //throw new NotImplementedException("GetName() is not implemented yet0");
            string name = Console.ReadLine();
            return name;
        }

        public static string GreetFriend(string name)
        {
            //throw new NotImplementedException("GreetFriend() is not implemented yet");
            return $"Hello, {name}. You are my friend.";
        }

        public static double GetNumber()
        {
            //throw new NotImplementedException("GetNumber() is not implemented yet");
            bool success;
            double number;
            do
            {
              Console.WriteLine("Input a number: ");
              success = Double.TryParse(Console.ReadLine(), out number);
            } while(!success);

            return number;
        }

        public static int GetAction()
        {
            //throw new NotImplementedException("GetAction() is not implemented yet");
          int selection;
          bool success;
          Console.WriteLine("Choose a mathematical operator: ");
          Console.Write("1. Add \n 2. Subtract \n 3. Multiply \n 4. Divide");
          success = Int32.TryParse(Console.ReadLine(), out selection);
          return selection;
        }

        public static double DoAction(double x, double y, int action)
        {
            //throw new NotImplementedException("DoAction() is not implemented yet");
            // My solution
            // if (action == 1)
            // {
            //   return x + y;
            // }
            // else if (action == 2)
            // {
            //   return x - y;
            // }
            // else if (action == 3)
            // {
            //   return x * y;
            // }
            // else
            // {
            //   return x / y;
            // }
            // Mark's solution
            // I did not find the max and min values before subtracting and dividing
            switch (action)
            {
                case 1:
                    return x + y;
                case 2:
                    return Math.Max(x, y) - Math.Min(x, y);
                case 3:
                    return x * y;
                case 4:
                    return Math.Max(x, y) / Math.Min(x, y);
                default:
                    throw new FormatException("Something went wrong in DoAction()");
            }
        }
    }
}
