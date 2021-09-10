using System;

namespace _9_ClassesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
          string fName = "Bob";
          string lName = "Belcher";
          string anEyeColor = "Brown";
          int anAge = 44;

          Human human1one = new Human();

          Human human1two = new Human(fName, lName);
          Console.WriteLine(human1two.AboutMe());

          Human2 human2one = new Human2(fName, lName, anEyeColor);
          Console.WriteLine(human2one.AboutMe2());

          Human2 human2two = new Human2(fName, lName, anAge);
          Console.WriteLine(human2two.AboutMe2());

          Human2 human2three = new Human2(fName, lName, anEyeColor, anAge);
          Console.WriteLine(human2three.AboutMe2());

          Human2 human2four = new Human2();
          human2four.Weight = 100;
          Console.WriteLine($"I weigh {human2four.Weight} lbs.");
          human2four.Weight = 500;
          Console.WriteLine($"I weigh {human2four.Weight} lbs.");
        }
    }
}
