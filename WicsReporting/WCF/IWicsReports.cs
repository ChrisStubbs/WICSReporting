using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WicsReporting.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWicsReports" in both code and config file together.
    [ServiceContract]
    public interface IWicsReports
    {
        [OperationContract]
        [System.ServiceModel.Web.WebInvoke(Method = "GET", 
            ResponseFormat = System.ServiceModel.Web.WebMessageFormat.Json, 
            BodyStyle = System.ServiceModel.Web.WebMessageBodyStyle.Wrapped,
            UriTemplate = "summary?m={measure}&tp={tradingParty}&fy={financialYear}")]
        string Summary(string measure,string tradingParty,string financialYear);
    }
}
