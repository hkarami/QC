using LaboratoryQualityControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Services.Users
{
    interface IUserService
    {
        #region [Methods]
        User GetDeviceByID(int usercode);
        void DeleteDevice(User user);
        IList<User> GetAllDevice();
        void UpdateDevice(User user);
        void InsertDevice(User user);
        #endregion
    }
}
