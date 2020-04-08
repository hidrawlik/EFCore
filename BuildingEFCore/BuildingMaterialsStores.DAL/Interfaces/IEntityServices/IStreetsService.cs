using BuildingMaterialsStores.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMaterialsStores.DAL.Interfaces.IEntityServices
{
    public interface IStreetsService
    {
        Task<IEnumerable<Streets>> GetAllStreets();

        Task<Streets> GetStreet(int Id);

        Task AddStreet(Streets street);

        Task UpdateStreet(Streets street);
        
        Task DeleteStreet(Streets street);
    }
}
