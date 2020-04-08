using BuildingMaterialsStores.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace BuildingMaterialsStores.DAL.Entities
{
    public partial class Stocks : IEntity
    {
        public Stocks()
        {
            ProductsInStocks = new HashSet<ProductsInStocks>();
            StockStore = new HashSet<StockStore>();
        }

        public int Id { get; set; }
        public int Street { get; set; }
        public int HouseNumber { get; set; }

        public virtual Streets StreetNavigation { get; set; }
        public virtual ICollection<ProductsInStocks> ProductsInStocks { get; set; }
        public virtual ICollection<StockStore> StockStore { get; set; }
    }
}
