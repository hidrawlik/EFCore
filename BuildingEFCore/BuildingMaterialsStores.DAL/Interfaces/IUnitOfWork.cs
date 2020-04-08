using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BuildingMaterialsStores.DAL.Interfaces.IEntityRepositories;

namespace BuildingMaterialsStores.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IProductsRepository ProductsRepository { get; }
        IStocksRepository StocksRepository { get; }
        IStoresRepository StoresRepository { get; }
        IStreetsRepository StreetsRepository { get; }
    }
}
