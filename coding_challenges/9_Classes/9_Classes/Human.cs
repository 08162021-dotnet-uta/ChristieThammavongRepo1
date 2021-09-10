using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    internal class Human
    {
      private string _lastName = "Smyth";
      private string _firstName = "Pat";

      public Human() { }
      public Human(string fName, string lName)
      {
        _firstName = fName;
        _lastName = lName;
      }

      public string AboutMe()
      {
        return $"My name is {_firstName} {_lastName}.";
      }
      
    }//end of class
}//end of namespace