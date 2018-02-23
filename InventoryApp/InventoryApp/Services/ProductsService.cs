using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using InventoryApp.Models;

namespace InventoryApp.Services
{
    public class ProductsService
    {
        private List<Product> list = new List<Product>();

        public IEnumerable<Product> Products {
            get{
                return this.list;
            }
        }

        public ProductsService()
        {
            this.list.Add(new Product(){Id = 1, Name = "Pen", Cost=5, Units=10});
        }

        public Product GetById(int Id){
            return this.list.Single(product => product.Id == Id);
        }
        public Product AddNew(Product productData){

            var newProductId = this.list.Any() ? this.list.Max(product => product.Id) + 1 : 1;
            var newProduct = new Product
            {
                Id = newProductId,
                Name = productData.Name,
                Cost = productData.Cost,
                Units = productData.Units
            };
            this.list.Add(newProduct);
            return newProduct;
        }

        public Product Update(Product productData)
        {
            this.list = this.list.Select(product => product.Id == productData.Id ? productData : product).ToList();
            return productData;
        }

        public void Remove(int Id){
            this.list = this.list.Where(product => product.Id != Id).ToList();
        }
    }
}
