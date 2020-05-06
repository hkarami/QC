using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.Roles
{
    public class RoleService : BaseService<Role>, IRoleService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public RoleService(LaboratoryQCContext dbContext, IRepository<Role> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteRole(Role role)
        {
            if (role==null)
            {
                throw new ArgumentNullException(nameof(role));
            }
            MainRepository.Delete(role);
        }

        public IList<Role> GetAllRoles()
        {
            return MainRepository.Table.ToList();
        }

        public Role GetRoleById(int rolecode)
        {
            if (rolecode==0)
            {
                return null;
            }
            return MainRepository.GetById(rolecode);
        }

        public void InsertRole(Role role)
        {
            if (role==null)
            {
                throw new ArgumentNullException(nameof(role));
            }
            MainRepository.Insert(role);
        }

        public void UpdateRole(Role role)
        {
            if (role==null)
            {
                throw new ArgumentNullException(nameof(role));
            }

            MainRepository.Update(role);
        }
        #endregion
    }
}
