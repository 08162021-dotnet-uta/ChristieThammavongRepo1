using System;

namespace C_
{
    class Program
    {
        public static string ReverseCase(string phrase)
        {
          string reversed = "";
          for(int i = 0; i < phrase.Length; i++)
          {
            if(char.IsUpper(phrase[i]))
            {
              reversed += char.ToLower(phrase[i]);
            }
            else if(char.IsLower(phrase[i]))
            {
              reversed += char.ToUpper(phrase[i]);
            }
            else if(phrase[i] == ' ')
            {
              reversed += phrase[i];
            }
          }
          return reversed;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseCase("Happy Birthday")); // "hAPPY bIRTHDAY"

            Console.WriteLine(ReverseCase("MANY THANKS")); // "many thanks"

            Console.WriteLine(ReverseCase("sPoNtAnEoUs")); // "SpOnTaNeOuS"
        }
    }
}
