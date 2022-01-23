using IVS_ShopOnCoreMvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IVS_ShopOnCoreMvc.Data.Interfaces
{
    interface IVehiclesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
