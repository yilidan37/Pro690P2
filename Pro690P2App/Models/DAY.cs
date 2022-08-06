using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro690P2.Models
{
    public class DAY
    {
        public float maxtemp_c { get; set; }
        public float mintemp_c { get; set; }
        public float avgtemp_c { get; set; }
        public float maxwind_kph { get; set; }
        public float daily_chance_of_rain { get; set; }

        public float daily_chance_of_snow { get; set; }
        public float uv { get; set; }
    }
}
