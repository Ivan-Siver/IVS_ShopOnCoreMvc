using IVS_ShopOnCoreMvc.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IVS_ShopOnCoreMvc.Data.Models
{
    public class Car : IVehicles
    {
        public Guid id { set; get; }

        public string name { set; get; }

        public string shortDescription { set; get; }

        public string longDescription { set; get; }

        public string image { set; get; }

        public ushort price { set; get; }
        
        /// <summary>
        /// Flag for show on home-page
        /// </summary>
        public bool isFavourite { set; get; }

        public int available { set; get; }

        public int categoryId { set; get; }

        public virtual Category Category { set; get; }
    }
}
