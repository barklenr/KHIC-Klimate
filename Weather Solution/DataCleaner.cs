using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Solution
{
    public class DataCleaner
    {
        public string RemoveHTML(string html)
        {
            char[] arrayOfChars = html.ToCharArray();
            List<char> listOfChars = new List<char>();
            bool isHtmlCode = false;

            for (int i = 0; i < arrayOfChars.Length; i++)
            {
                if (arrayOfChars[i] == '<')
                {
                    isHtmlCode = true;
                }
                else if (arrayOfChars[i] == '>')
                {
                    isHtmlCode = false;
                }
                else if (isHtmlCode == false)
                {
                    listOfChars.Add(arrayOfChars[i]);
                }
            }

            string noHtml = "";

            for (int i = 0; i < listOfChars.Count; i++)
            {
                noHtml = noHtml + listOfChars[i];
            }

            string noNBSP = removeStringNBSP(noHtml);

            return noNBSP;
        }

        private string removeStringNBSP(string noHtml)
        {
            string toReturn = "";

            string[] lines = noHtml.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(lines[i]))
                {
                    // Yo dawg! This "if" prevents the clean data from having blank lines.
                }
                else if (lines[i].Contains("&nbsp;"))
                {
                    bool isData = true;
                    List<char> list = new List<char>();

                    char[] arrayOfChars = lines[i].ToCharArray();

                    for (int x = 0; x < arrayOfChars.Length; x++)
                    {
                        if (arrayOfChars[x] == '&')
                        {
                            isData = false;
                        }
                        else if (arrayOfChars[x] == ';')
                        {
                            isData = true;
                        }
                        else if (isData)
                        {
                            list.Add(arrayOfChars[x]);
                        }
                    }

                    string notWorthless = "";

                    for (int x = 0; x < list.Count; x++)
                    {
                        notWorthless = notWorthless + list[x];
                    }

                    toReturn = toReturn + "\n" + notWorthless.Trim();

                }
                else
                {
                    toReturn = toReturn + "\n" + lines[i].Trim();
                }
            }

            return toReturn;
        }
    }
}
