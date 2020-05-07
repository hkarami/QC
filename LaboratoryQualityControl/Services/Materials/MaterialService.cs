using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.Materials
{
    public class MaterialService : BaseService<Material>, IMaterialService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public MaterialService(LaboratoryQCContext dbContext, IRepository<Material> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteMaterial(Material material)
        {
            if (material==null)
            {
                throw new ArgumentNullException(nameof(material));
            }
            MainRepository.Delete(material);
        }

        public IList<Material> GetAllMaterials()
        {
            return MainRepository.Table.ToList();
        }

        public Material GetMaterialById(int materialid)
        {
            if (materialid==0)
            {
                return null;
            }
            return MainRepository.GetById(materialid);
        }

        public void InsertMaterial(Material material)
        {
            if (material==null)
            {
                throw new ArgumentNullException(nameof(material));
            }
            MainRepository.Insert(material);
        }

        public void UpdateMaterial(Material material)
        {
            if (material==null)
            {
                throw new ArgumentNullException(nameof(material));
            }
            MainRepository.Update(material);
        }
        #endregion
    }
}
