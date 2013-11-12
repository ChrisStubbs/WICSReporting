using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WicsReporting.Classes
{
    public class WicsPerformanceSummaryHtmlTable
    {
        private readonly List<WicsPerformanceSummary> _list = null;
        private StringBuilder _html = null;

        public WicsPerformanceSummaryHtmlTable(IEnumerable<WicsPerformanceSummary> list)
        {
            _list = list.ToList();
        }

        private void AddTableHeader(StringBuilder sb)
        {
            var item = _list.First();
            sb.Append("<thead>");
            sb.AppendFormat("<tr><th class='noBorderOrShading'></th><th colspan='3'>{0}</th></tr>", item.Measure.Value);
            sb.AppendFormat("<tr><th>{0}</th><th>{1}</th><th>{2}</th><th>{3}</th></tr>", item.TradingParty, "Failure", "Txns", "Rate");
            sb.Append("<thead>");
        }

        private string GetHtml()
        {
            if (_html == null)
            {
                _html = new StringBuilder();
                if (_list.Count > 0)
                {
                    _html.Append("<table>");
                    AddTableHeader(_html);
                    foreach (var item in _list)
                    {
                        _html.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>", item.Month.Name,
                                           item.Failures, item.Transactions, item.PercentageRate);
                    }

                    _html.Append("</table>");
                }
            }

            return _html.ToString();
        }

        public string HTML
        {
            get { return GetHtml(); }
        }



    }
}