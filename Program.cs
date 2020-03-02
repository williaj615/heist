using System;
using System.Collections.Generic;

namespace heist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan Your Heist!");

      Dictionary<string, string> teamMember = new Dictionary<string, string>();

      Console.WriteLine("Enter Your Team Member's name.");

      string memberName = Console.ReadLine();

      teamMember.Add("Name", memberName);

      Console.WriteLine("Thanks! Now, enter your team member's skill level.");

      string memberLevel = Console.ReadLine();
      //   int memberLevelInt = int.Parse(memberLevel);
      teamMember.Add("Skill Level", memberLevel);

      Console.WriteLine("Awesome! Now, enter your team member's courage factor.");

      string memberFactor = Console.ReadLine();
      //   int memberFactorInt = int.Parse(memberFactor);
      teamMember.Add("Courage Factor", memberFactor);

      foreach (KeyValuePair<string, string> pair in teamMember)
      {
        Console.WriteLine($"The team member's {pair.Key} is {pair.Value}");
      }
    }
  }
}