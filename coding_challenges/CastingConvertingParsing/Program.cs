using System;

namespace CastingConvertingParsing
{
    class Program
    {
        static void Main(string[] args)
        {
          // Casting


          // Implicit Casting
          float myFloat = 12.34f;
          double myDouble = myFloat;
          Console.WriteLine("Implicit Casting: " + myDouble);

          // Explicit Casting
          long myLong = 980;
          short myShort = (short)myLong;
          Console.WriteLine("Explicit Casting: " + myShort);

          // Converting
          // Could be useful when you are sure what type the data is,
          // and what kind of information it would hold

          // Pros
          // Can be used with objects
          // 
          string line = "cat";
          string numLine = "1234";
          try
          {
            // int number = Convert.ToInt32(line);
            // Console.WriteLine("Convert a String to Int: " + number);
            double numberLine = Convert.ToDouble(numLine);
            Console.WriteLine("Convert to Double: " + numberLine);
          }
          catch(Exception e)
          {
            Console.WriteLine(e.Message);
          }

          // Parsing
          // TryParse basically does the try/catch for you
          string value = "1234";
          try
          {
            int num = Int32.Parse(value);
            Console.WriteLine("Parsing: " + num);
          }
          catch(Exception e)
          {
            Console.WriteLine(e.Message);
          }

          // Convert takes an object as an 
          // input/argument where parse takes a string.

          // The convert methods will never throw an 
          // ArgumentNullException if you passed null as 
          // an argument, it will simply return the default 
          // value for the value type you are trying to 
          // convert to, for example 0 for integers, where 
          // Parse will throw an exception if you pass it null.

          // Now when it comes to converting strings both the
          // convert and the parse methods will do the same
          // thing, so in that case I recommend using Parse/TryParse.

          // If you are dealing with your own custom types
          // then, you can implement the IConvertible
          // interface to provide your own implementation and
          // use the Convert method to convert from other types
          // to your own custom types.

        }
    }
}
