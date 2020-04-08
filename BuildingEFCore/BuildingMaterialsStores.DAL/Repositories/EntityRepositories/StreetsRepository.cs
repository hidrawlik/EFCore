using BuildingMaterialsStores.DAL.Entities;
using BuildingMaterialsStores.DAL.Interfaces.IEntityRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingMaterialsStores.DAL.Repositories.EntityRepositories
{
    public class StreetsRepository : GenericRepository<Streets>, IStreetsRepository
    {
        public StreetsRepository(BuildContext db)
            : base(db)
        {
        }
    }
}
