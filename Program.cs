using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;


namespace SunriseSunsetAPI
{
    class Program
    {
        public static string url = "https://api.sunrise-sunset.org/json?lat=59.4370&lng=24.7536&date=2020-10-13";
        static void Main(string[] args)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responsereader= new StreamReader(webStream))
            {
                var response = responsereader.ReadToEnd();
                SunMode sunMode = JsonConvert.DeserializeObject<SunMode>(response);
                Console.WriteLine($"Sunrise:{sunMode.Results.Sunrise}.");
                Console.WriteLine($"Sunset:{sunMode.Results.Sunset}");
                Console.WriteLine($"Status:{sunMode.Status}");
            }
        }
    }
}
