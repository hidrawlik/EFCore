using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BuildingMaterialsStores.DAL.Entities;
using BuildingMaterialsStores.DAL.Interfaces;
using BuildingMaterialsStores.DAL.Interfaces.IEntityServices;

namespace BuildingMaterialsStores.DAL.Services
{
    public class StreetsService : IStreetsService
    {
        private readonly IUnitOfWork _UnitOfWork;

        public StreetsService(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public async Task AddStreet(Streets street)
        {
            await _UnitOfWork.StreetsRepository.Add(street);
        }

        public async Task DeleteStreet(Streets street)
        {
            await _UnitOfWork.StreetsRepository.Delete(street);
        }

        public async Task<IEnumerable<Streets>> GetAllStreets()
        {
            return await _UnitOfWork.StreetsRepository.GetAll();
        }

        public async Task<Streets> GetStreet(int Id)
        {
            return await _UnitOfWork.StreetsRepository.Get(Id);
        }

        public async Task UpdateStreet(Streets street)
        {
            await _UnitOfWork.StreetsRepository.Update(street);
        }
    }
}
