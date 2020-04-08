using BuildingMaterialsStores.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace BuildingMaterialsStores.DAL.Entities
{
    public partial class Streets : IEntity
    {
        public Streets()
        {
            Stocks = new HashSet<Stocks>();
            Stores = new HashSet<Stores>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Stocks> Stocks { get; set; }
        public virtual ICollection<Stores> Stores { get; set; }
    }
}
