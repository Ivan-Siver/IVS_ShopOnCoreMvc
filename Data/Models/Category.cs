using IVS_ShopOnCoreMvc.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IVS_ShopOnCoreMvc.Data.Models
{
    public class Category
    {
        public Guid id { set; get; }

        public string categoryName { set; get; }

        public string description { set; get; }

        public IEnumerable<IVehicles> vehicles { set; get; }
    }
}
