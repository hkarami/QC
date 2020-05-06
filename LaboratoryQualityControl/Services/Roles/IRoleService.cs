using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.Roles
{
    interface IRoleService
    {
        #region [Methods]
        Role GetRoleById(int rolecode);

        void DeleteRole(Role role);
        IList<Role> GetAllRoles();

        void InsertRole(Role role);

        void UpdateRole(Role role);

        #endregion
    }
}
