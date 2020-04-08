using BuildingMaterialsStores.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMaterialsStores.DAL.Interfaces.IEntityServices
{
    public interface IProductsService
    {
        Task<IEnumerable<Products>> GetAllProducts();
        
        Task<Products> GetProduct(int Id);
        
        Task AddProduct(Products product);
     
        Task UpdateProduct(Products product);
    
        Task DeleteProduct(Products product);
    }
}
