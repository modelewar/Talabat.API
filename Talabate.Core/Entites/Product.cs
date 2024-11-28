using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabate.Core.Entites
{
    internal class Product
    {
        //
        public int id { get; set; }
        public string Name { get; set; }
        public string Describtion { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
    }
}
