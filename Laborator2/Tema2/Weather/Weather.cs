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
