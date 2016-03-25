using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Net;

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

        public String retrieveMickeyString()
        {
            return "http://raider.mountunion.edu/~bagnolta/RaiderRadar/SorcererMickey.jpg";
        }

        
    }
}
