using Geocoding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeocodingTester
{
    class Program
    {
        static void Main(string[] args)
        {
            // BEFORE YOU BEGIN: include your Google Geocoding API key in API/keys.xml and update the xml path in Keys.cs

            try
            {
                Geocoder location = new Geocoder(streetNumber: "1450", streetName: "Jayhawk Blvd", city: "Lawrence", state: "KS", postalCode: "66045");
                Console.WriteLine("Formatted Address: {0}", location.FormattedAddress);
                Console.WriteLine("Street Number: {0}", location.StreetNumber);
                Console.WriteLine("Street Name: {0}", location.StreetName);
                Console.WriteLine("City: {0}", location.City);
                Console.WriteLine("State: {0}", location.State);
                Console.WriteLine("State Abbreviation: {0}", location.StateAbbreviation);
                Console.WriteLine("Postal Code: {0}", location.PostalCode);
                Console.WriteLine("Postal Code Suffix: {0}", location.PostalCodeSuffix);
                Console.WriteLine("County: {0}", location.County);
                Console.WriteLine("Country: {0}", location.Country);
                Console.WriteLine("Country Abbreviation: {0}", location.CountryAbbreviation);
                Console.WriteLine("Latitude: {0}", location.Latitude);
                Console.WriteLine("Longitude: {0}", location.Longitude);
                Console.WriteLine("Place ID: {0}", location.PlaceID);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                Console.WriteLine("Verify you've provided a valid path to the file Keys.xml");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                Console.WriteLine("Verify you've provided a valid Google Geocoding API key in Keys.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
