using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BuildingMaterialsStores.DAL.Interfaces.IEntityServices;
using BuildingMaterialsStores.DAL.Interfaces;
using BuildingMaterialsStores.DAL.Entities;

namespace BuildingMaterialsStores.DAL.Services
{
    public class ProductsService : IProductsService
    {
        private IUnitOfWork _UnitOfWork;

        public ProductsService(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public async Task AddProduct(Products product)
        {
            await _UnitOfWork.ProductsRepository.Add(product);
        }

        public async Task DeleteProduct(Products product)
        {
            await _UnitOfWork.ProductsRepository.Delete(product);
        }

        public async Task<IEnumerable<Products>> GetAllProducts()
        {
            return await _UnitOfWork.ProductsRepository.GetAll();
        }

        public async Task<Products> GetProduct(int Id)
        {
            return await _UnitOfWork.ProductsRepository.Get(Id);
        }

        public async Task UpdateProduct(Products product)
        {
            await _UnitOfWork.ProductsRepository.Update(product);
        }
    }
}
