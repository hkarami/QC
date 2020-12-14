using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Services.DateTimeService
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime ToGeorgianDateTime(string persianDate)
        {
            int year = Convert.ToInt32(persianDate.Substring(0, 4));
            int month = Convert.ToInt32(persianDate.Substring(5, 2));
            int day = Convert.ToInt32(persianDate.Substring(8, 2));
            int hour = Convert.ToInt32(persianDate.Substring(11, 2));
            int minute= Convert.ToInt32(persianDate.Substring(14, 2));
            int second=Convert.ToInt32(persianDate.Substring(15, 2));
            DateTime georgianDateTime = new DateTime(year, month, day,hour,minute,second, new System.Globalization.PersianCalendar());
            return georgianDateTime;
        }

        public string ToPersianDateString(DateTime georgianDate)
        {
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

            string year = persianCalendar.GetYear(georgianDate).ToString();
            string month = persianCalendar.GetMonth(georgianDate).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(georgianDate).ToString().PadLeft(2, '0');
            string hour = persianCalendar.GetHour(georgianDate).ToString().PadLeft(2, '0');
            string minute = persianCalendar.GetMinute(georgianDate).ToString().PadLeft(2, '0');
            string second = persianCalendar.GetSecond(georgianDate).ToString().PadLeft(2,'0');
            string persianDateString = string.Format("{0}/{1}/{2} {3}:{5}:{6}", year, month, day,hour,minute,second);
            return persianDateString;
        }
    }
}
