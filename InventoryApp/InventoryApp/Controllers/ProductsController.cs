using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryApp.Models;
using InventoryApp.Services;

namespace InventoryApp.Controllers
{
    
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private ProductsService productsService;

        public ProductsController(ProductsService productsService){
            this.productsService = productsService;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return this.productsService.Products;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return this.productsService.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public Product Post([FromBody]Product productData)
        {
            return this.productsService.AddNew(productData);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Product Put(int id, [FromBody]Product productToUpdate)
        {
            return this.productsService.Update(productToUpdate);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.productsService.Remove(id);
        }
    }
}
