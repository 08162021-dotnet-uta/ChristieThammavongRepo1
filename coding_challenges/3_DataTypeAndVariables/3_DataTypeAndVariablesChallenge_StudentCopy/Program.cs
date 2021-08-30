using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //
            //
            // Insert code here.
            //
            //
            int number = 5;
            PrintValues(number);
        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {
            //throw new NotImplementedException($"PrintValues() has not been implemented");
            switch (obj)
            {
              case byte Byte:
                return "Data type => byte";
              case sbyte Sbyte:
                return "Data type => sbyte";
              case int Int:
                return "Data type => int";
              case uint Uint:
                return "Data type => uint";
              case short Short:
                return "Data type => short";
              case ushort Ushort:
                return "Data type => ushort";
              case float Float:
                return "Data type => float";
              case double Double:
                return "Data type => double";
              case char Char:
                return "Data type => char";
              case bool Bool:
                return "Data type => bool";
              case string String:
                return "Data type => string";
              case decimal Decimal:
                return "Data type => decimal";
              case long Long:
                return "Data type => long";
              case ulong Ulong:
                return "Data type => ulong";
              default:
                return "0";
            }
        }

        /// <summary>
        /// THis method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {
            //throw new NotImplementedException($"StringToInt() has not been implemented");
          bool success = Int32.TryParse(numString, out int num);
          if (success)
          {
            return num;
          }
          else
          {
            return null;
          }
        }
    }// end of class
}// End of Namespace
