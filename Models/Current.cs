using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro690P2.Models
{
    public class Current
    {
        public string last_updated { get; set; }
        public float temp_c { get; set; }
        public float wind_kph { get; set; }
        public float feelslike_c { get; set; }
        public float humidity { get; set; }
        public float uv { get; set; }
    }
}
