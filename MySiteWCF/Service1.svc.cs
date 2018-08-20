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
            using (Context context = new Context())
            {
                Info info = context._Info.ToList().Last();

                RequestInfo request = new RequestInfo();
                request.HumidityValue = info.HumidityValue;
                request.PressureValue = info.PressureValue;
                request.TemperatureValue = info.TemperatureValue;

                return request;
            }
        }


        public void SendInfo(string Temperature, string Pressure, string Humidity)
        {
            using (Context context = new Context())
            {
                Info info = new Info();
                info.TemperatureValue = Temperature;
                info.PressureValue = Pressure;
                info.HumidityValue = Humidity;

                context._Info.Add(info);
                context.SaveChanges();
            }

        }

        public RequestUserSign SignUser(string Login, string Password)
        {
            using (Context context = new Context())
            {
                UserSign DataBaseUser = context.Users.FirstOrDefault(x => x.Login == Login && x.Password == Password);
                if (DataBaseUser != null)
                {
                    RequestUserSign request = new RequestUserSign();
                    request.Login = Login;
                    request.Password = Password;
                    return request;
                }
                return null;
            }
        }


        public void RegisterUser(string Login, string Password)
        {
            using (Context context = new Context())
            {
                UserSign DataBaseUser = context.Users.FirstOrDefault(x => x.Login == Login && x.Password == Password);
                if (DataBaseUser == null)
                {
                    UserSign RegUser = new UserSign();
                    RegUser.Login = Login;
                    RegUser.Password = Password;

                    context.Users.Add(RegUser);
                    context.SaveChanges();
                }   
            }
        }


    }
}
