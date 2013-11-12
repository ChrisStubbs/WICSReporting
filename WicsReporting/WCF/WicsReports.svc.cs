using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Web;
using WicsReporting.Classes;
namespace WicsReporting.WCF
{


    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WicsReports" in code, svc and config file together.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)] 
    public class WicsReports:IWicsReports
    {

        public HttpContext Context
        {
            get
            {
                return HttpContext.Current;
            }
        }
        
        public string Summary(string measure, string tradingParty, string financialYear)
        {
            var data = WicsPerformanceSummaryTestData.GetData().Where(x=> x.Measure.Key == measure && x.TradingParty == tradingParty).ToList();
            return new WicsPerformanceSummaryHtmlTable(data).HTML;
        }
    }
}
