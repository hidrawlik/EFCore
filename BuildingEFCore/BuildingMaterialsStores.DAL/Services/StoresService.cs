using BuildingMaterialsStores.DAL.Entities;
using BuildingMaterialsStores.DAL.Interfaces;
using BuildingMaterialsStores.DAL.Interfaces.IEntityServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMaterialsStores.DAL.Services
{
    public class StoresService : IStoresService
    {
        private IUnitOfWork _UnitOfWork;

        public StoresService(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public async Task AddStore(Stores store)
        {
            await _UnitOfWork.StoresRepository.Add(store);
        }

        public async Task DeleteStore(Stores store)
        {
            await _UnitOfWork.StoresRepository.Delete(store);
        }

        public async Task<IEnumerable<Stores>> GetAllStores()
        {
            return await _UnitOfWork.StoresRepository.GetAll();
        }

        public async Task<Stores> GetStore(int Id)
        {
            return await _UnitOfWork.StoresRepository.Get(Id);
        }

        public async Task UpdateStore(Stores store)
        {
            await _UnitOfWork.StoresRepository.Update(store);
        }
    }
}
