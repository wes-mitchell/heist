using System;
using System.Collections.Generic;

namespace Heist
{
  public class Team
  {
    public List<TeamMember> TeamList { get; set; }
    // public void AddMember(TeamMember member)
    // {
    //   TeamList.Add(member);
    // }
    public Team(List<TeamMember> team)
    {
      TeamList = team;
    }
    public void Description()
    {
      foreach(TeamMember member in TeamList)
      {
        Console.WriteLine(member);
      }
    }

  }

}