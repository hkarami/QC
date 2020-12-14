using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Services.DateTimeService
{
    interface IDateTimeService
    {
        #region [Methods]
        DateTime ToGeorgianDateTime(this string persianDate);
        string ToPersianDateString(this DateTime georgianDate);
        #endregion
    }
}
