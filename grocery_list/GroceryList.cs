using System;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = { "eggs", "milk", "bananas", "cereal", "rice", "yogurt" };
    Console.WriteLine("My grocery list: ");
    for (int index = 0; index < myGroceryList.Length; index ++)
    {
      Console.WriteLine(myGroceryList[index]);
    }
  }
}