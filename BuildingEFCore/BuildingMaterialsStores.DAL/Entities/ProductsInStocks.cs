using System;
using System.Collections.Generic;

namespace BuildingMaterialsStores.DAL.Entities
{
    public partial class ProductsInStocks
    {
        public int Stock { get; set; }
        public int Product { get; set; }
        public int? Number { get; set; }

        public virtual Products ProductNavigation { get; set; }
        public virtual Stocks StockNavigation { get; set; }
    }
}
