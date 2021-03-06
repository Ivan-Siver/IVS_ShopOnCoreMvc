using IVS_ShopOnCoreMvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IVS_ShopOnCoreMvc.Data.Interfaces
{
    public interface IVehicles
    {
        IEnumerable<Vehicle> Vehicles { get;}
        IEnumerable<Vehicle> GetFavouriteVehicles { get; set; }
        Vehicle GetObjectCar(Guid carId);
    }
}
