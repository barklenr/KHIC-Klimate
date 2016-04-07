using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Net;
using System.Web.Services;

namespace TimeLapseManager
{
    public class ImageRetriever
    {

        String log = "";

        public ImageRetriever()
        {
            var textFromFile = (new WebClient()).DownloadString("http://raider.mountunion.edu/~bagnolta/RaiderRadar/LOG.TXT");

            Console.Out.WriteLine("HERE");
            Console.Out.WriteLine(textFromFile);
            Console.Out.WriteLine("HERE");
        }

        [WebMethod]
        public String retrieveMickeyString()
        {
            return "http://raider.mountunion.edu/~bagnolta/RaiderRadar/SorcererMickey.jpg";
        }

        public String standbyString()
        {
            return "http://raider.mountunion.edu/~bagnolta/RaiderRadar/2016_3_23_15_35.jpg";
        }

        public List<String> getImagesFromLog()
        {
            var webClient = new WebClient();
            string readHtml = webClient.DownloadString("http://raider.mountunion.edu/~bagnolta/RaiderRadar/log.txt");

            String[] splitText = readHtml.Split('\n');

            return splitText.ToList();
        }

        
    }
}
