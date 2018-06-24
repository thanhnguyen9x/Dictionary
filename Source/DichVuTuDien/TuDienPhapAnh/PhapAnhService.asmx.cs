using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TuDienPhapViet;

namespace TuDienPhapAnh
{
    /// <summary>
    /// Summary description for PhapAnhService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PhapAnhService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public string GetMean(string fr)
        {
            string en = "not found !";
            DataProvider dataProvider = new DataProvider();
            en = dataProvider.GetMean(fr);
            return en;
        }
    }
}
