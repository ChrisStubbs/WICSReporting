using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WicsReporting.Classes
{
    public class WicsPerformanceSummaryTestData
    {
        private const string R1A_CODE = "R1A";
        private const string R1A_DESCRIPTION = "R1A Partial Registrations";


        public static IList<WicsPerformanceSummary> GetData()
        {
            var list = new List<WicsPerformanceSummary>();

            list.Add(new WicsPerformanceSummary
            {
                Failures = 10,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.April(),
                TradingParty = "AIMERA",
                Transactions = 100
            });

            list.Add(new WicsPerformanceSummary
            {
                Failures = 7,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.May(),
                TradingParty = "AIMERA",
                Transactions = 105
            });

            list.Add(new WicsPerformanceSummary
            {
                Failures =14,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.May(),
                TradingParty = "AIMERA",
                Transactions = 150
            });

            list.Add(new WicsPerformanceSummary
            {
                Failures = 11,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.June(),
                TradingParty = "AIMERA",
                Transactions = 123
            });

            list.Add(new WicsPerformanceSummary
            {
                Failures = 8,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.July(),
                TradingParty = "AIMERA",
                Transactions = 85
            });

            list.Add(new WicsPerformanceSummary
            {
                Failures = 12,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.August(),
                TradingParty = "AIMERA",
                Transactions = 142
            });



            list.Add(new WicsPerformanceSummary
            {
                Failures = 99,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.April(),
                TradingParty = "SWBS",
                Transactions = 500
            });

            list.Add(new WicsPerformanceSummary
            {
                Failures = 77,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.May(),
                TradingParty = "SWBS",
                Transactions = 520
            });

            list.Add(new WicsPerformanceSummary
            {
                Failures = 158,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.May(),
                TradingParty = "SWBS",
                Transactions = 622
            });

            list.Add(new WicsPerformanceSummary
            {
                Failures = 111,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.June(),
                TradingParty = "SWBS",
                Transactions = 1009
            });

            list.Add(new WicsPerformanceSummary
            {
                Failures = 27,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.July(),
                TradingParty = "SWBS",
                Transactions = 805
            });

            list.Add(new WicsPerformanceSummary
            {
                Failures = 99,
                Measure = new KeyValuePair<string, string>(R1A_CODE, R1A_DESCRIPTION),
                Month = Month.August(),
                TradingParty = "SWBS",
                Transactions = 222
            });

            return list;
        }
    }
}