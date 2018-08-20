using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MySiteWCF
{

    public class Info
    {
        public int Id { get; set; }

        public string TemperatureValue { get; set; }

        public string PressureValue { get; set; }

        public string HumidityValue { get; set; }

        public DateTime Date { get; set; }
    }
}