using BuildingMaterialsStores.DAL.Interfaces;
using BuildingMaterialsStores.DAL.Interfaces.IEntityRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingMaterialsStores.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IProductsRepository _ProductsRepository;
        private readonly IStocksRepository _StocksRepository;
        private readonly IStoresRepository _StoresRepository;
        private readonly IStreetsRepository _StreetsRepository;

        public UnitOfWork(IProductsRepository ProductsRepository,
            IStocksRepository StocksRepository,
            IStoresRepository StoresRepository,
            IStreetsRepository StreetsRepository
            )
        {
            _ProductsRepository = ProductsRepository;
            _StocksRepository = StocksRepository;
            _StoresRepository = StoresRepository;
            _StreetsRepository = StreetsRepository;
        }

        public IProductsRepository ProductsRepository
        {
            get
            {
                return _ProductsRepository;
            }
        }

        public IStocksRepository StocksRepository
        {
            get
            {
                return _StocksRepository;
            }
        }

        public IStoresRepository StoresRepository
        {
            get
            {
                return _StoresRepository;
            }
        }

        public IStreetsRepository StreetsRepository
        {
            get
            {
                return _StreetsRepository;
            }
        }
    }
}
