using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Solution
{
    class WeatherDataRetriever
    {
        public string GetHTML(string website)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(website);
            }
        }

        public void WriteToFile(string filePath, string data)
        {
            System.IO.File.WriteAllText(filePath, data);
        }
    }
}
