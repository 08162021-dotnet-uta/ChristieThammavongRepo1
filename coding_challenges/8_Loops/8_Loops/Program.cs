using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Your code here */

        }

        /// <summary>
        /// Return the number of elements in the List<int> that are odd.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseFor(List<int> x)
        {
          //  throw new NotImplementedException("UseFor() is not implemented yet.");
          int numOdd = 0;
          for (int i = 0; i < x.Count; i++)
          {
            if ((x[i] % 2) != 0)
            {
              numOdd++;
            }
          }
          return numOdd;
        }

        /// <summary>
        /// This method counts the even entries from the provided List<object> 
        /// and returns the total number found.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForEach(List<object> x)
        {
          //  throw new NotImplementedException("UseForEach() is not implemented yet.");
          int numEven = 0;
          // foreach (object item in x)
          // {
          //   try
          //   {
          //     result = Convert.ToInt32(item);
          //     if(result % 2 == 0)
          //     {
          //       numEven++;
          //     }
          //   }
          //   catch(FormatException)
          //   {
          //     Console.WriteLine("Cannot convert to an int");
          //   }
          // }
          foreach (object item in x)
          {
            if (item is double || item is float || item is short 
                || item is byte || item is long)
            {
              if((long)item % 2 == 0) numEven++;
            }
            else if (item is int)
            {
              if((int)item % 2 == 0) numEven++;
            }
          }
          return numEven;
        }

        /// <summary>
        /// This method counts the multiples of 4 from the provided List<int>. 
        /// Exit the loop when the integer 1234 is found.
        /// Return the total number of multiples of 4.
        /// </summary>
        /// <param name="x"></param>
        public static int UseWhile(List<int> x)
        {
          //  throw new NotImplementedException("UseFor() is not implemented yet.");
          int numMultFour = 0;
          int i = 0;
          while(x[i] != 1234 && i < x.Count)
          {
            if ((x[i] % 4) == 0)
            {
              numMultFour++;
            }
            i++;
          }
          return numMultFour;
        }

        /// <summary>
        /// This method will evaluate the Int Array provided and return how many of its 
        /// values are multiples of 3 and 4.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForThreeFour(int[] x)
        {
          //  throw new NotImplementedException("UseForThreeFour() is not implemented yet.");
          int numThreeFour = 0;
          foreach(int i in x)
          {
            if (((i % 3) == 0) && ((i % 4) == 0))
            {
              numThreeFour++;
            }
          }
          return numThreeFour;
        }

        /// <summary>
        /// This method takes an array of List<string>'s. 
        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
        /// </summary>
        /// <param name="stringListArray"></param>
        /// <returns></returns>
        public static string LoopdyLoop(List<string>[] stringListArray)
        {
          //  throw new NotImplementedException("LoopdyLoop() is not implemented yet.");
          string concatenatedString = "";
          for (int i = 0; i < stringListArray.Length; i++)
          {
            foreach(string item in stringListArray[i])
            {
              concatenatedString += (item + ' ');
            }
          }
          return concatenatedString;
        }
    }
}