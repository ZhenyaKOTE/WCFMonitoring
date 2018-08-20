using MySiteWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MySiteWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped,
                           Method = "GET",
                           ResponseFormat = WebMessageFormat.Json,
                           UriTemplate = "/SendInfo?Tem={Temperature}&Press={Pressure}&Hum={Humidity}")]
        void SendInfo(string Temperature, string Pressure, string Humidity);


        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped,
                           Method = "GET",
                           ResponseFormat = WebMessageFormat.Json,
                           UriTemplate = "/GetInfo")]
        RequestInfo GetInfo();

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped,
                           Method = "GET",
                           ResponseFormat = WebMessageFormat.Json,
                           UriTemplate = "/SignUser?Log={Login}&Pass={Password}")]
        RequestUserSign SignUser(string Login, string Password);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped,
                   Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   UriTemplate = "/RegisterUser?Log={Login}&Pass={Password}")]
        void RegisterUser(string Login, string Password);




    }
}
