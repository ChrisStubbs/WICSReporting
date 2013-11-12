using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using WicsReporting.Classes;

namespace WicsReporting
{
    public partial class _Default : System.Web.UI.Page
    {
        //http://www.codeproject.com/Articles/307229/JSON-Enabled-WCF-Services-Part-1
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                var tradingParty = Request.QueryString["tp"] ?? "AIMERA";
                var measure = Request.QueryString["m"] ?? "R1A";
                var data = WicsPerformanceSummaryTestData.GetData().Where(x => 
                    x.Measure.Key == measure 
                    && x.TradingParty == tradingParty).ToList();

                ltlsummaryReportData.Text = new WicsPerformanceSummaryHtmlTable(data).HTML;

            }
        }

        [WebMethod]
        public static object GetData(string param)
        {
            return new { param = param };
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
