using MySiteWCF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MySiteWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public RequestInfo GetInfo()
        {
            Context context = new Context();
            List<Info> inf = context._Info.ToList();
            inf.Reverse();
            Info info = inf[0];

            Debug.WriteLine(info.TemperatureValue);

            RequestInfo request = new RequestInfo();
            request.HumidityValue = info.HumidityValue;
            request.PressureValue = info.PressureValue;
            request.TemperatureValue = info.TemperatureValue;

            return request;
        }

        public void SendInfo(string Temperature, string Pressure, string Humidity)
        {

            Info info = new Info();
            info.TemperatureValue = Temperature;
            info.PressureValue = Pressure;
            info.HumidityValue = Humidity;

            Context context = new Context();
            context._Info.Add(info);
            context.SaveChanges();

        }
    }
}
