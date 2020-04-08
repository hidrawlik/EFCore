using BuildingMaterialsStores.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace BuildingMaterialsStores.DAL.Entities
{
    public partial class Products : IEntity
    {
        public Products()
        {
            ProductsInStocks = new HashSet<ProductsInStocks>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public double? Price { get; set; }

        public virtual ICollection<ProductsInStocks> ProductsInStocks { get; set; }
    }
}
