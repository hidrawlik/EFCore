using BuildingMaterialsStores.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMaterialsStores.DAL.Interfaces.IEntityServices
{
    public interface IStocksService
    {
        Task<IEnumerable<Stocks>> GetAllStocks();

        Task<Stocks> GetStock(int Id);

        Task AddStock(Stocks stock);

        Task UpdateStock(Stocks stock);

        Task DeleteStock(Stocks stock);
    }
}
