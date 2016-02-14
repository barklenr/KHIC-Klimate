using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WeatherDataInformation weatherData = new WeatherDataInformation();
            WeatherDataRetriever weatherDataRetriever = new WeatherDataRetriever();
            DataCleaner dataCleaner = new DataCleaner();
            string html = weatherDataRetriever.GetHTML("http://raider.mountunion.edu/~weather/Bracy_Vantage_Pro_Plus.htm");
            string cleanData = dataCleaner.RemoveHTML(html);
            //weatherDataRetriever.WriteToFile(@"C:\Users\TIMMAH\Desktop\html.txt", html);
            //weatherDataRetriever.WriteToFile(@"C:\Users\TIMMAH\Desktop\clean.txt", cleanData);
            MAKEITPRETTY pretty = new MAKEITPRETTY(cleanData, weatherData);
            weatherDataRetriever.WriteToFile(@"C:\Users\TIMMAH\Desktop\data.txt", weatherData.ToString());
            this.Close();
        }
    }
}
