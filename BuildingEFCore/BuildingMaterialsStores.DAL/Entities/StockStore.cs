using System;
using System.Collections.Generic;

namespace BuildingMaterialsStores.DAL.Entities
{
    public partial class StockStore
    {
        public int StockId { get; set; }
        public int StoreId { get; set; }

        public virtual Stocks Stock { get; set; }
        public virtual Stores Store { get; set; }
    }
}
