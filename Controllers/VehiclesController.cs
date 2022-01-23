using IVS_ShopOnCoreMvc.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IVS_ShopOnCoreMvc.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly IVehicles _vehicles;
        private readonly IVehiclesCategory _vehiclesCategory;

        public VehiclesController(IVehicles vehicles, IVehiclesCategory vehiclesCategory)
        {
            _vehicles = vehicles;
            _vehiclesCategory = vehiclesCategory;
        }

        public ViewResult List()
        {
            var vehicles = _vehicles.Vehicles;
            return View(vehicles);
        }
    }
}
