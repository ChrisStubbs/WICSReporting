using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WicsReporting.Classes
{
    public class WicsPerformanceSummary
    {
        public Month Month { get; set; }
        public KeyValuePair<string,string> Measure { get; set; }
        
        public string TradingParty { get; set; }
        public int Failures { get; set; }
        public int Transactions { get; set; }
        public string PercentageRate
        {
            get
            {
                return string.Format("{0:0.0%}", (double)Failures / Transactions);
            }
        }

    }
}