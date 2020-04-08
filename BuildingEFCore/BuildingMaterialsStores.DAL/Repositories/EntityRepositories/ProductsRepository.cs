using BuildingMaterialsStores.DAL.Entities;
using BuildingMaterialsStores.DAL.Interfaces.IEntityRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using BuildingMaterialsStores.DAL;
using Microsoft.EntityFrameworkCore;

namespace BuildingMaterialsStores.DAL.Repositories.EntityRepositories
{
    public class ProductsRepository : GenericRepository<Products>, IProductsRepository
    {
        public ProductsRepository(BuildContext db)
            : base(db)
        {
        }
    }
}
