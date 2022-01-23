using IVS_ShopOnCoreMvc.Data.Interfaces;
using IVS_ShopOnCoreMvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IVS_ShopOnCoreMvc.Data.Mocks
{
    public class MockVehiclesCategory : IVehiclesCategory
    {
        public IEnumerable<Category> AllCategories
        { 
            get 
            {
                return new List<Category>
                {
                    new Category { categoryName = "Racing Car", description = "Гоночный автомобиль"},
                    new Category { categoryName = "Utility Vehicle", description = "Внедорожник"},
                    new Category { categoryName = "Truck", description = "Грузовик"}
                };
            }   
        }
    }
}
