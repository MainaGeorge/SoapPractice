using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;

namespace SOAP.WebServiceExample
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service : WebService
    {
        private double GetMinInternal(params double[] numbers)
        {
            return numbers.Min();
        }

        [WebMethod]
        public double GetMin(double[] d)
        {
            return GetMinInternal(d);
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double GetMin3(double d1, double d2, double d3)
        {
            return GetMinInternal(d1, d2, d3);
        }

        [WebMethod]
        public List<string> SplitBySpace(string s)
        {
            return s.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
        }

    }
}
