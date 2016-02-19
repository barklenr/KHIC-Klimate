using System;
using Weather_Solution;

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
        

    }
}