using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Pro690P2.Models
{
    public class Response
    {
        public Location location { get; set; }
        public Current current { get; set; }
        public Forecast forecast { get; set; }
    }
}
