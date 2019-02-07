using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Geocoding.API
{
    public static class Keys
    {
        public static string KeysXml = @"PATH_TO_KEYS.XML";

        public static string GoogleGeocoding
        {
            get
            {
                try
                {
                    XmlDocument xdoc = new XmlDocument();

                    if (!File.Exists(KeysXml))
                    {
                        throw new FileNotFoundException("Keys.xml could not be found");
                    }

                    xdoc.Load(KeysXml);
                    string apiKey = xdoc.GetElementsByTagName("GoogleGeocoding").Item(0).InnerText;
                    return apiKey;
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Make sure the Keys.xml file exists, and you've provided the path.");
                    throw e;
                }
            }
        }
    }
}
