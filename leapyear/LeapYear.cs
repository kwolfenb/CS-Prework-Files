using System;

class LeapYear
{
  static void Main()
  {
    Console.WriteLine("In which year were you born?");
    string birthYearString = Console.ReadLine();
    int birthYearInt = int.Parse(birthYearString);
    int leapYearAge = 0;

    Console.WriteLine("You were alive for the following leap years:");

    for (int year = birthYearInt; year < 2018; year++)
    {
      if (year % 4 == 0)
      {
        Console.WriteLine(year);
        leapYearAge += 1;
      }
    
    }
    Console.WriteLine("Your age in leap years is " + leapYearAge);
  }
}