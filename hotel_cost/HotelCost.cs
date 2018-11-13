using System;

class HotelCost
{
  static void Main()
  {
    Console.WriteLine("In which season will you be staying with us?");
    string season = Console.ReadLine();

    Console.WriteLine("On the weekend or a weeknight?");
    string dayOfWeek = Console.ReadLine();

    bool summer = season == "summer";
    bool weekend = dayOfWeek == "weekend";

    if (summer && weekend)
    {
      Console.WriteLine("Your stay is probably going to be pretty expensive. It's both peak travel season AND the weekend.");
    }
    else if (summer || weekend)
    {
      Console.WriteLine("Your stay may be more expensive than normal.");
    }
    else if (!(summer || weekend))
    {
      Console.WriteLine("You are staying at a great time to get the cheapest rates.");
    }
    else 
    {
      Console.WriteLine("Your stay probably won't be too expensive!");
    }
  }
}