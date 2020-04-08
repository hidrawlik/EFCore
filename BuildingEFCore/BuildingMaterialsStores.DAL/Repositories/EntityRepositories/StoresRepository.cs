using BuildingMaterialsStores.DAL.Entities;
using BuildingMaterialsStores.DAL.Interfaces.IEntityRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingMaterialsStores.DAL.Repositories.EntityRepositories
{
    public class StoresRepository : GenericRepository<Stores>, IStoresRepository
    {
        public StoresRepository(BuildContext db)
            : base(db)
        {
        }
    }
}
