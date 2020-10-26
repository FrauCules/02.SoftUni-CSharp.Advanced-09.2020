using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public int GetDaysDifference(string startDateString, string endDateString)
        {
            //1992 05 31 - year montht day
            //2016 06 17
            DateTime startDate = DateTime.Parse(startDateString);
            DateTime endtDate = DateTime.Parse(endDateString);

            var totalDays = Math.Abs((int)(endtDate- startDate).TotalDays);

            return totalDays;
        }
    }
}
