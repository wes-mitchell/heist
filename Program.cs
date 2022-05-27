using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("----------------");

            List<TeamMember> teamList = new List<TeamMember>();

            Bank thisBank = new Bank(100);

            Random luck = new Random();
            int bankLuck = luck.Next(-10, 10);

            thisBank.Difficulty += bankLuck;

            Console.Write("What is your team member's name? ");
            string name = Console.ReadLine();
            Console.Write("What is the skill level of your member? ");
            int skill = int.Parse(Console.ReadLine());
            Console.Write("What is your team member's courage factor (0.0 - 2.0) ");
            decimal courage = decimal.Parse(Console.ReadLine());

            while (courage < 0 || courage > 2)
            {
                Console.Write("What is your team member's courage factor (0.0 - 2.0) ");
                courage = decimal.Parse(Console.ReadLine());
            }

            TeamMember firstMember = new TeamMember(name, skill, courage);
            teamList.Add(firstMember);

            Team newTeam = new Team(teamList);

            int skillSum = 0;
            skillSum += skill;

            while(true)
            {
                Console.Write("What is your team member's name? ");
                name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name)) 
                {
                    break;
                }
                else 
                {
                    Console.Write("What is the skill level of your member? ");
                    skill = int.Parse(Console.ReadLine());
                    skillSum += skill;
                    Console.Write("What is your team member's courage factor (0.0 - 2.0) ");
                    courage = decimal.Parse(Console.ReadLine());
                while (courage < 0 || courage > 2)
                {
                    Console.Write("What is your team member's courage factor (0.0 - 2.0) ");
                    courage = decimal.Parse(Console.ReadLine());
                }
                TeamMember thisMember = new TeamMember(name, skill, courage);
                teamList.Add(thisMember);
                }
            }

            if (skillSum >= thisBank.Difficulty) 
            {
                
                Console.WriteLine("");
                Console.WriteLine($"Your teams total skill level was {skillSum}");
                Console.WriteLine($"The bank's difficulty was {thisBank.Difficulty}");
                Console.WriteLine("");
                Console.WriteLine("You robbed the damn bank, nice!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"Your teams total skill level was {skillSum}");
                Console.WriteLine($"The bank's difficulty was {thisBank.Difficulty}");
                Console.WriteLine("");
                Console.WriteLine("Weaksauce, try again next time.");
            }

            TeamMember member = new TeamMember(name, skill, courage);
        }
    }
}
