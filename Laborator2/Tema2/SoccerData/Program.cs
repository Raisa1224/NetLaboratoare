using System;
using System.Collections.Generic;

namespace SoccerData
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of Teams
            List<Team> TeamList = new List<Team>();

            string line;
            string header;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Admin\Downloads\football.dat");

            header = file.ReadLine();

            while ((line = file.ReadLine()) != null)
            {
                // Check if it's a line that contains data
                if(-1 != line.IndexOfAny("12345678".ToCharArray()))
                {
                    Team currentTeam = new Team(line);
                    TeamList.Add(currentTeam);
                }
            }

            file.Close();

            int MinimumPointDifference = -1;
            string TeamNameWithMinimumPointDifference = "";


            foreach (Team team in TeamList)
            {
                int CurrentPointDifference = team.GetPointDifference();
                if (MinimumPointDifference == -1 || CurrentPointDifference < MinimumPointDifference)
                {
                    MinimumPointDifference = CurrentPointDifference;
                    TeamNameWithMinimumPointDifference = team.GetName();
                }
            }

            Console.WriteLine("The team with the minimum point difference is: " + TeamNameWithMinimumPointDifference + " and their point difference is: " + MinimumPointDifference);
        }
    }
}
