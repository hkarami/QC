using LaboratoryQualityControl.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.Users
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(LaboratoryQCContext dbContext, IRepository<User> repository) : base(dbContext, repository)
        {
        }

        public void DeleteDevice(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            MainRepository.Delete(user);
        }

        public IList<User> GetAllDevice()
        {
            return MainRepository.Table.ToList();
        }

        public User GetDeviceByID(int usercode)
        {
            if (usercode == 0)
            {
                return null;
            }
            return MainRepository.GetById(usercode);
        }

        public void InsertDevice(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
        }

        public void UpdateDevice(User user)
        {
            if (user==null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            MainRepository.Update(user);
        }
    }
}
