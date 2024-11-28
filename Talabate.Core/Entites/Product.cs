using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabate.Core.Entites
{
    public class Product : BaseEntity
    {

        public string Name { get; set; }
        public string Describtion { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
        public int ProductBrandId { get; set; } //Fk
        public ProductBrand ProductBrand { get; set; }
        public int ProductTypeId { get; set; } //Fk 
        public ProductType ProductType { get; set; }
    }
}
