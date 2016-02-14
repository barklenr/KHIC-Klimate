using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Solution
{
    class WeatherDataInformation
    {
        public String CurrentTemperature;
        public String Humidity;
        public String Wind;
        public String Barometer;
        public String TodaysRain;
        public String WindChill;
        public String HighTemperature;
        public String LowTemperature;

        override
        public String ToString()
        {
            return "Current Temperature: " + CurrentTemperature + "\n" +
                   "Humidity: " + Humidity + "\n" +
                   "Wind: " + Wind + "\n" +
                   "Barometer: " + Barometer + "\n" +
                   "Today's Rain: " + TodaysRain + "\n" +
                   "Wind Chill: " + WindChill + "\n" +
                   "Today's High Temperature: " + HighTemperature + "\n" +
                   "Today's Low Temperature: " + LowTemperature;
        }
    }
}
