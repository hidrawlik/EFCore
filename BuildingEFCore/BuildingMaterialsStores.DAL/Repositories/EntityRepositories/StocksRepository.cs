using BuildingMaterialsStores.DAL.Entities;
using BuildingMaterialsStores.DAL.Interfaces.IEntityRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingMaterialsStores.DAL.Repositories.EntityRepositories
{
    public class StocksRepository : GenericRepository<Stocks>, IStocksRepository
    {
        public StocksRepository(BuildContext db)
            : base(db)
        {
        }
    }
}
