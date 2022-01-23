using IVS_ShopOnCoreMvc.Data.Interfaces;
using IVS_ShopOnCoreMvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IVS_ShopOnCoreMvc.Data.Mocks
{
    public class MockVehicles : IVehicles
    {
        private readonly IVehiclesCategory _vehiclesCategory;
        public IEnumerable<Vehicle> Vehicles {
            get {
                return new List<Vehicle>
                {
                    new Vehicle {
                        name = "BMW M3 GTR",
                        shortDescription = "MyCar",
                        longDescription = "Не пройден",
                        image = "",
                        price = 0,
                        isFavourite = true,
                        available = true,
                        Category = _vehiclesCategory.AllCategories.Where(x => x.categoryName == "Racing Car").First()
                    },
                    new Vehicle {
                        name = "Lexus IS300",
                        shortDescription = "Buyed",
                        longDescription = "Продан, всвязи с получением премиум-автомобиля той же марки",
                        image = "",
                        price = 10000,
                        isFavourite = false,
                        available = false,
                        Category = _vehiclesCategory.AllCategories.Where(x => x.categoryName == "Racing Car").First()
                    },
                    new Vehicle {
                        name = "WolksVagen Golf GTI",
                        shortDescription = "PinkList",
                        longDescription = "Не пройден",
                        image = "",
                        price = 0,
                        isFavourite = true,
                        available = true,
                        Category = _vehiclesCategory.AllCategories.Where(x => x.categoryName == "Racing Car").First()
                    },
                    new Vehicle {
                        name = "Lexus IS300", 
                        shortDescription = "PinkList", 
                        longDescription = "FullTuned & Пройден", 
                        image = "",
                        price = 0, 
                        isFavourite = false, 
                        available = true,
                        Category = _vehiclesCategory.AllCategories.Where(x => x.categoryName == "Racing Car").First()
                    },
                    new Vehicle {
                        name = "Shevrolett PickUp",
                        shortDescription = "MyCar",
                        longDescription = "FullTuned",
                        image = "",
                        price = 0,
                        isFavourite = true,
                        available = true,
                        Category = _vehiclesCategory.AllCategories.Where(x => x.categoryName == "Utility Vehicle").First()
                    },
                };
            }
        }

        public IEnumerable<Vehicle> GetFavouriteVehicles { get; set; }

        public Vehicle GetObjectCar(Guid carId)
        {
            throw new NotImplementedException();
        }
    }
}
