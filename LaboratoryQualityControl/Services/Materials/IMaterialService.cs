using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.Materials
{
    interface IMaterialService
    {
        #region [Methods]
        Material GetMaterialById(int materialid);

        void DeleteMaterial(Material material);
        IList<Material> GetAllMaterials();

        void InsertMaterial(Material material);

        void UpdateMaterial(Material material);

        #endregion
    }
}
