using System;
namespace InventoryApp.Models
{
    public class Product
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public decimal Cost
        {
            get;
            set;
        }
        public int Units
        {
            get;
            set;
        }

        public Product()
        {
        }
    }
}
