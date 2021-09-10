using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    internal class Human2
    {
      private string _lastName = "Smyth";
      private string _firstName = "Pat";
      private string _eyeColor;
      private int _age;
      private int _weight;

      public Human2() { }

      public Human2(string fName, string lName, string anEyeColor, int anAge)
      {
        _firstName = fName;
        _lastName = lName;
        _eyeColor = anEyeColor;
        _age = anAge;
      }
      public Human2(string fName, string lName)
      {
        _firstName = fName;
        _lastName = lName;
      }
      public Human2(string fName, string lName, int anAge)
      {
        _firstName = fName;
        _lastName = lName;
        _age = anAge;
      }

      public Human2(string fName, string lName, string anEyeColor)
      {
        _firstName = fName;
        _lastName = lName;
        _eyeColor = anEyeColor;
      }

      public int Weight
      {
        get
        {
          return _weight;
        }

        set
        {
          if (value < 0 || value > 400)
          {
            _weight = 0;
          }
          else
          {
            _weight = value;
          }
        }
      }

      public string AboutMe()
      {
        return $"My name is {_firstName} {_lastName}.";
      }

      public string AboutMe2()
      {
        if (_eyeColor == null && _age != 0)
        {
          return $"My name is {_firstName} {_lastName}. My age is {_age}.";
        }
        else if (_eyeColor != null && _age == 0)
        {
          return $"My name is {_firstName} {_lastName}. My eye color is {_eyeColor}.";
        }
        else if (_eyeColor != null && _age != 0)
        {
          return $"My name is {_firstName} {_lastName}. My age is {_age}. My eye color is {_eyeColor}.";
        }
        else
        {
          return $"My name is {_firstName} {_lastName}.";
        }
      }
    }
}