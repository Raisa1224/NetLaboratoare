using System;
using System.Collections.Generic;

namespace WeatherData
{
    class Program
    {
        static void Main(string[] args)
        {

            //list of Weathers
            List<Weather> WeatherList = new List<Weather>();

            string line;
            string header;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Admin\Downloads\weather.dat");
            
            header = file.ReadLine();
            
            // Read the line that is empty
            file.ReadLine();

            while ((line = file.ReadLine()) != null)
            {
                Weather currentWeather = new Weather(line);
                WeatherList.Add(currentWeather);
            }

            file.Close();

            double MinimumSpread = -1;
            string DayWithMinimumSpread = "";


            foreach(Weather weather in WeatherList)
            {
                double CurrentSpread = weather.GetTemperatureSpread();
                if(MinimumSpread == -1 || CurrentSpread < MinimumSpread)
                {
                    MinimumSpread = CurrentSpread;
                    DayWithMinimumSpread = weather.GetDay();
                }
            }

            Console.WriteLine("The day with the minimun spread is: " + DayWithMinimumSpread + " and the minimum spread is: " + MinimumSpread);
        }
    }
}
