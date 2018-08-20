using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MySiteWCF.Models
{
    [DataContract]
    public class RequestInfo
    {

        [DataMember]
        public string TemperatureValue { get; set; }
        [DataMember]
        public string PressureValue { get; set; }
        [DataMember]
        public string HumidityValue { get; set; }
    }
}