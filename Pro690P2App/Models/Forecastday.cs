using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro690P2.Models
{
    public class Forecastday
    {
        public string date { get; set; }
        public DAY day { get; set; }
        public Astro astro { get; set; }
    }
}
