using System;
using Weather_Solution;
using TimeLapseManager;
using System.Drawing;
using System.Net;

public partial class MountUnionClimate : System.Web.UI.Page
{

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

        ImageRetriever retriever = new ImageRetriever();
        String first = retriever.retrieveMickeyString();
        timelapse.Attributes["src"] = first;

        var textFromFile = (new WebClient()).DownloadString("http://raider.mountunion.edu/~bagnolta/RaiderRadar/LOG.TXT");

        Console.Out.WriteLine("HERE");
        Console.Out.WriteLine(textFromFile);
        Console.Out.WriteLine("HERE");

    }


}