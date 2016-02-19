using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather_Solution
{
    public class MAKEITPRETTY
    {
        private String[] array;

        public MAKEITPRETTY(string currentWeatherAtBracy, WeatherDataInformation weatherData)
        {
            array = currentWeatherAtBracy.Split('\n');

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals("Temperature"))
                {
                    weatherData.CurrentTemperature = array[i + 1];
                }
                if (array[i].Equals("Humidity"))
                {
                    weatherData.Humidity = array[i + 1];
                }
                if (array[i].Equals("Wind"))
                {
                    weatherData.Wind = array[i + 1];
                }
                if (array[i].Equals("Barometer"))
                {
                    weatherData.Barometer = array[i + 1];
                }
                if (array[i].Equals("Today's Rain"))
                {
                    weatherData.TodaysRain = array[i + 1];
                }
                if (array[i].Equals("Wind Chill"))
                {
                    weatherData.WindChill = array[i + 1];
                }
                if (array[i].Equals("High TemperatureLow Temperature"))
                {
                    weatherData.HighTemperature = array[i + 1] + " " + array[i + 2] + " " + array[i + 3].Substring(0, 6);
                    if (array[i + 3].Contains("Fat"))
                    {
                        array[i + 3] = Regex.Replace(array[i + 3], "Fat", "F at");
                    }
                    weatherData.LowTemperature = array[i + 3].Substring(6) + " " + array[i + 4];
                }
            }

            //Console.Out.WriteLine(weatherData.ToString());

        }
    }
}
