using System;
using System.Collections.Generic;

namespace heist
{
  class Program
  {
    static void Main(string[] args)
    {

      int bankDifficulty = 100;

      List<Dictionary<string, string>> teamMembers = new List<Dictionary<string, string>>();

      Console.WriteLine("Plan Your Heist!");


      while (true)
      {
        Dictionary<string, string> teamMember = new Dictionary<string, string>();

        Console.WriteLine("Enter Your Team Member's name.");

        string memberName = Console.ReadLine();
        if (memberName == "")
        {
          break;
        }

        teamMember.Add("Name", memberName);

        Console.WriteLine("Thanks! Now, enter your team member's skill level.");

        string memberLevel = Console.ReadLine();
        //   int memberLevelInt = int.Parse(memberLevel);
        teamMember.Add("Skill Level", memberLevel);

        Console.WriteLine("Awesome! Now, enter your team member's courage factor.");

        string memberFactor = Console.ReadLine();
        //   int memberFactorInt = int.Parse(memberFactor);
        teamMember.Add("Courage Factor", memberFactor);

        teamMembers.Add(teamMember);
      }

      Console.WriteLine($"Sweet! You have created a team with {teamMembers.Count} members.");

      foreach (Dictionary<string, string> member in teamMembers)
      {

        foreach (KeyValuePair<string, string> pair in member)
        {
          Console.WriteLine($"The team member's {pair.Key} is {pair.Value}");
        }
      }

      int skillTotal = 0;
      int luckFactor = new Random().Next(-10, 11);
      int trueDifficulty = bankDifficulty + luckFactor;

      foreach (Dictionary<string, string> member in teamMembers)
      {
        int memberSkillInt = int.Parse(member["Skill Level"]);
        skillTotal += memberSkillInt;
      }

      Console.WriteLine($"Your team's total skill level is {skillTotal}.");
      Console.WriteLine($"The difficulty of robbing this bank is {trueDifficulty}.");

      if (skillTotal >= trueDifficulty)
      {
        Console.WriteLine("Sick, y'all can totally loot this place. 🤟🏾");
      }
      else
      {
        Console.WriteLine("Sorry, you're going to have to beef up your skills to take this place down.");
      }
    }
  }
}