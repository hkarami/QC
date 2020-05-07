using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.LogBookDevices
{
    public class LogBookDeviceService : BaseService<LogBookDevice>, ILogBookDeviceService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public LogBookDeviceService(LaboratoryQCContext dbContext, IRepository<LogBookDevice> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteLogBookDevice(LogBookDevice logbookdevice)
        {
            if (logbookdevice==null)
            {
                throw new ArgumentNullException(nameof(logbookdevice));
            }
            MainRepository.Delete(logbookdevice);
        }

        public IList<LogBookDevice> GetAllLogBookDevices()
        {
            return MainRepository.Table.ToList();
        }

        public LogBookDevice GetLogBookDeviceById(int idlogbook)
        {
            if (idlogbook==0)
            {
                return null;
            }
            return MainRepository.GetById(idlogbook);
        }

        public void InsertLogBookDevice(LogBookDevice logbookdevice)
        {
            if (logbookdevice==null)
            {
                throw new ArgumentNullException(nameof(logbookdevice));
            }
            MainRepository.Insert(logbookdevice);
        }

        public void UpdateLogBookDevice(LogBookDevice logbookdevice)
        {
            if (logbookdevice==null)
            {
                throw new ArgumentNullException(nameof(logbookdevice));
            }
            MainRepository.Update(logbookdevice);
        }
        #endregion
    }
}
