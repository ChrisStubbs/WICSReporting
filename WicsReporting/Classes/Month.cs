using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WicsReporting.Classes
{
    public struct Month
    {
        public string Name { get; set; }
        public int BusinessMonth { get; set; }
       
        public static Month April()
        {
            return new Month {BusinessMonth = 1, Name = "April"};
        }
        public static Month May()
        {
            return new Month { BusinessMonth = 2, Name = "May" };
        }
        public static Month June()
        {
            return new Month { BusinessMonth = 3, Name = "June" };
        }
        public static Month July()
        {
            return new Month { BusinessMonth = 4, Name = "July" };
        }
        public static Month August()
        {
            return new Month { BusinessMonth = 5, Name = "August" };
        }
        public static Month September()
        {
            return new Month { BusinessMonth = 6, Name = "September" };
        }
        public static Month October()
        {
            return new Month { BusinessMonth = 6, Name = "October" };
        }
        public static Month November()
        {
            return new Month { BusinessMonth = 8, Name = "November" };
        }
        public static Month December()
        {
            return new Month { BusinessMonth = 9, Name = "December" };
        }
        public static Month January()
        {
            return new Month { BusinessMonth = 10, Name = "January" };
        }
        public static Month February()
        {
            return new Month { BusinessMonth = 11, Name = "February" };
        }

        public static Month March()
        {
            return new Month { BusinessMonth = 11, Name = "March" };
        }


    }
}