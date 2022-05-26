using System;
using System.Runtime;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("----------------");
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

            TeamMember member = new TeamMember(name, skill, courage);
            Console.Write(member);
       
        }
    }
}
