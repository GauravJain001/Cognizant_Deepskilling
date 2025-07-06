using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailInventory.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        //Foreign Key
        public int CategoryId { get; set; }
        //Navigation Property
        public Category Category { get; set; }
    }
}
