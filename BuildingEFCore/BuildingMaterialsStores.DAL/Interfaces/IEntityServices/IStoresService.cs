using BuildingMaterialsStores.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMaterialsStores.DAL.Interfaces.IEntityServices
{
    public interface IStoresService
    {
        Task<IEnumerable<Stores>> GetAllStores();

        Task<Stores> GetStore(int Id);
        
        Task AddStore(Stores store);
        
        Task UpdateStore(Stores store);

        Task DeleteStore(Stores store);
    }
}
