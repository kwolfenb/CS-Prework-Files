using System;

class RatedR
{
  static void Main()
  {
    Console.WriteLine("How old are you?");
    string ageString = Console.ReadLine();
    int age = int.Parse(ageString);

    if (age >= 17)
    {
      Console.WriteLine("You can see the movie.");
    }
    else 
    {
      Console.WriteLine("I'm sorry, you are too young to see this movie.");
    }
  }
  
}