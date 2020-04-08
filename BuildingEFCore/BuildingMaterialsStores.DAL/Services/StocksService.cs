using BuildingMaterialsStores.DAL.Entities;
using BuildingMaterialsStores.DAL.Interfaces;
using BuildingMaterialsStores.DAL.Interfaces.IEntityServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMaterialsStores.DAL.Services
{
    public class StocksService : IStocksService
    {
        private IUnitOfWork _UnitOfWork;

        public StocksService(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public async Task AddStock(Stocks stock)
        {
            await _UnitOfWork.StocksRepository.Add(stock);
        }

        public async Task DeleteStock(Stocks stock)
        {
            await _UnitOfWork.StocksRepository.Delete(stock);
        }

        public async Task<IEnumerable<Stocks>> GetAllStocks()
        {
            return await _UnitOfWork.StocksRepository.GetAll();
        }

        public async Task<Stocks> GetStock(int Id)
        {
            return await _UnitOfWork.StocksRepository.Get(Id);
        }

        public async Task UpdateStock(Stocks stock)
        {
            await _UnitOfWork.StocksRepository.Update(stock);
        }
    }
}
