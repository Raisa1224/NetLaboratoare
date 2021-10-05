using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherData
{
    class Weather
    {
        string Day;
        double MaxTemperature; 
        double MinTemperature;
        double AverageTemperature;
        int HDDay;
        double AvDP;
        string OneHrP ;
        double TPcpn ;
        string WxType ;
        string PDir ;
        double AvSp ;
        string Dir ;
        int MxS ;
        double SkyC ;
        int MxR ;
        int MnR ;
        double AvSLP ;

        public Weather(string Line)
        {
            //split the string in substrings with the data members
            //convert each substring to the corresponding format for the data member
            //set the data members' values
            
            Line = Line.Replace("*", " ");
            string[] Columns = Line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            
            int columnCounter = 0;
            Day = Columns[columnCounter++];
            MaxTemperature = Convert.ToDouble(Columns[columnCounter++]);
            MinTemperature = Convert.ToDouble(Columns[columnCounter++]);
            AverageTemperature = Convert.ToDouble(Columns[columnCounter++]);

            if (-1 == Columns[columnCounter].IndexOf('.'))
            {
                HDDay = Convert.ToInt32(Columns[columnCounter++]);
            }

            AvDP = Convert.ToDouble(Columns[columnCounter++]);
            TPcpn = Convert.ToDouble(Columns[columnCounter++]);

            if (-1 != Columns[columnCounter].IndexOfAny("RTFH".ToCharArray()))
            {
                WxType = Columns[columnCounter++];
            }
            if (-1 == Columns[columnCounter].IndexOf('.'))
            {
                PDir = Columns[columnCounter++];
            }

            AvSp = Convert.ToDouble(Columns[columnCounter++]);

            if (Columns[columnCounter].Length > 2 && -1 != Columns[columnCounter].IndexOf('0'))
            {
                Dir = Columns[columnCounter++];
            }
            if (-1 == Columns[columnCounter].IndexOf('.'))
            {
                MxS = Convert.ToInt32(Columns[columnCounter++]);
            }

            SkyC = Convert.ToDouble(Columns[columnCounter++]);

            if (columnCounter < Columns.Length)
            {
                MxR = Convert.ToInt32(Columns[columnCounter++]);
                MnR = Convert.ToInt32(Columns[columnCounter++]);
                AvSLP = Convert.ToDouble(Columns[columnCounter]);
            }
        }

        public double GetTemperatureSpread()
        {
            return this.MaxTemperature - this.MinTemperature;
        }

        public string GetDay()
        {
            return this.Day;
        }
    }
}
