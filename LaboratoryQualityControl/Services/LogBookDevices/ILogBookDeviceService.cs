using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.LogBookDevices
{
    interface ILogBookDeviceService
    {
        #region [Methods]
        LogBookDevice GetLogBookDeviceById(int idlogbook);

        void DeleteLogBookDevice(LogBookDevice logbookdevice);
        IList<LogBookDevice> GetAllLogBookDevices();

        void InsertLogBookDevice(LogBookDevice logbookdevice);

        void UpdateLogBookDevice(LogBookDevice logbookdevice);

        #endregion
    }
}
