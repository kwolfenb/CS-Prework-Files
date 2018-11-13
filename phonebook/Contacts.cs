// Phonebook using custom classes and Objects
using System;
using System.Collections.Generic;

public class Contact
{
  public string Name;
  public string Phone;
  public string Address;
}

class Program
{
  public static void Main()
  {
    Contact hendrix = new Contact();
    hendrix.Name = "Jimmy Hendrix";
    hendrix.Phone = "123-456-0000";
    hendrix.Address = "208 SW 5th St. Seattle, WA 98108";

    Contact elvis = new Contact();
    elvis.Name = "Elvis Presley";
    elvis.Phone = "123-456-2222";
    elvis.Address = "123 Main St. Graceland, TN 52104";

    Contact einstein = new Contact();
    einstein.Name = "Albert Einstein";
    einstein.Phone = "123-456-4565";
    einstein.Address = "3718 MLK Blvd. Oakland, CA 94609";

    Contact marie = new Contact();
    marie.Name = "Marie Curie";
    marie.Phone = "123-456-4565";
    marie.Address = "3718 MLK Blvd. Oakland, CA 94609";
    
    Contact janis = new Contact();
    janis.Name = "Janis Joplin";
    janis.Phone = "123-456-4565";
    janis.Address = "3718 MLK Blvd. Oakland, CA 94609";

    List<Contact> addressBook = new List<Contact> {hendrix, elvis, einstein, marie, janis};
    foreach(Contact person in addressBook)
    {
      Console.WriteLine("Name: " + person.Name);
      Console.WriteLine("Phone Number : " + person.Phone);
      Console.WriteLine("Address: " + person.Address);
    }
  }
}