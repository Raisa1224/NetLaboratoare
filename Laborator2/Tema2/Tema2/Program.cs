﻿using System;
using System.Collections.Generic;
using SoccerData;
using WeatherData;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {

            FileReader fileReader = new FileReader("C:\\Users\\Admin\\Downloads\\weather.dat");

            List<string> data = fileReader.GetDataLines();

            //foreach (string line in data) Console.WriteLine(line);

            List<Team> TeamList = new List<Team>();
            List<Weather> WeatherList = new List<Weather>();
            
            foreach(string line in data)
            {
                Weather weather = new Weather(line);
                WeatherList.Add(weather);
            }

            double MinimumSpread = -1;
            string DayWithMinimumSpread = "";


            foreach (Weather weather in WeatherList)
            {
                double CurrentSpread = weather.GetTemperatureSpread();
                if (MinimumSpread == -1 || CurrentSpread < MinimumSpread)
                {
                    MinimumSpread = CurrentSpread;
                    DayWithMinimumSpread = weather.GetDay();
                }
            }

            Console.WriteLine("The day with the minimun spread is: " + DayWithMinimumSpread + " and the minimum spread is: " + MinimumSpread);

            fileReader.OverwriteData("C:\\Users\\Admin\\Downloads\\football.dat");
            data = new List<string>();
            data = fileReader.GetDataLines();
            foreach (string line in data)
            {
                Team team = new Team(line);
                TeamList.Add(team);
            }

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
