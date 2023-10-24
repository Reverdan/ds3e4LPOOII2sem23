using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServer
{
    public class Service1 : IService1
    {
        public double somar(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
