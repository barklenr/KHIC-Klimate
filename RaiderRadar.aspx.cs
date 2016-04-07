using System;
using Weather_Solution;
using TimeLapseManager;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Web.Services;

public partial class MountUnionClimate : System.Web.UI.Page
{
    private bool run = false;
    Thread timeLapseThread;

    protected void Page_Load(object sender, EventArgs e)
    {
        WeatherDataInformation weatherData = new WeatherDataInformation();
        WeatherDataRetriever weatherDataRetriever = new WeatherDataRetriever();
        DataCleaner dataCleaner = new DataCleaner();
        string html = weatherDataRetriever.GetHTML("http://raider.mountunion.edu/~weather/Bracy_Vantage_Pro_Plus.htm");
        string cleanData = dataCleaner.RemoveHTML(html);
        //weatherDataRetriever.WriteToFile(@"C:\Users\TIMMAH\Desktop\html.txt", html);
        //weatherDataRetriever.WriteToFile(@"C:\Users\TIMMAH\Desktop\clean.txt", cleanData);
        MAKEITPRETTY pretty = new MAKEITPRETTY(cleanData, weatherData);

        lblCurrentTemperature.Text = "Current Temperature: " + weatherData.CurrentTemperature;
        lblHumidity.Text = "Humidity: " + weatherData.Humidity;
        lblWind.Text = "Wind: " + weatherData.Wind;
        lblBarometer.Text = "Barometer: " + weatherData.Barometer;
        lblTodaysRain.Text = "Today's Rain: " + weatherData.TodaysRain;
        lblWindChill.Text = "Wind Chill: " + weatherData.WindChill;
        lblHighTemperature.Text = "Today's High Temperature: " + weatherData.HighTemperature;
        lblLowTemperature.Text = "Today's Low Temperature: " + weatherData.LowTemperature;

        //MyIFrame.Attributes["src"] = "http://openweathermap.org/help/tiles.html?opacity=0.8&l=precipitation";
        MyIFrame.Attributes["src"] = "https://weather.com/weather/radar/interactive/l/USOH0013:1:US?layer=radarConus&zoom=7";
        //MyIFrame.Attributes["src"] = "http://www.accuweather.com/en/us/alliance-oh/44601/weather-radar/335070";

        timeLapseThread = new Thread(handleTimeLapse);
        timeLapseThread.Start();

        

    }

    [WebMethod]
    public static String doSomething()
    {
        return "hi";
    }

    [WebMethod]
    private void handleTimeLapse()
    {
        ImageRetriever retriever = new ImageRetriever();
        String address = "http://raider.mountunion.edu/~bagnolta/RaiderRadar/";
        String fileExtension = ".jpg";

        while (true)
        {
            if (run)
            {
                System.Collections.Generic.List<String> log = retriever.getImagesFromLog();
                foreach(String i in log)
                {
                    timelapse.Attributes["src"] = address + i + fileExtension;
                    Thread.Sleep(10000);
                }
            }
            else
            {
                string standby = retriever.standbyString();
                timelapse.Attributes["src"] = standby;
                Thread.Sleep(30000);
            }
        }
    }

}