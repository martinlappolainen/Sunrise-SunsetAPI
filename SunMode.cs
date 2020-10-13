using System;
using System.Collections.Generic;
using System.Text;

namespace SunriseSunsetAPI
{
    public class SunMode
    {
        public Results Results { get; set; }
        public string Status { get; set; }
    }
    public class Results
    {
        public string Sunrise { get; set; }
        public string Sunset { get; set; }

    }
       
}
