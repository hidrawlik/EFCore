using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BuildingMaterialsStores.DAL.Interfaces.IEntityServices;
using BuildingMaterialsStores.DAL.Entities;

namespace BuildingMaterialsStores.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        [HttpGet]
        public async Task<IEnumerable<Products>> Get()
        {
            return await productsService.GetAllProducts();
        }

        [Route("{Id}")]
        [HttpGet]
        public async Task<Products> Get(int Id)
        {
            return await productsService.GetProduct(Id);
        }

        [HttpPost]
        public async Task<ActionResult<Products>> Add(Products product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            await productsService.AddProduct(product);
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<Products>> Update(Products product)
        {
            if (product == null)
            {
                return BadRequest();
            }

            if (productsService.GetProduct(product.Id) == null)
            {
                return NotFound();
            }

            await productsService.UpdateProduct(product);
            return Ok(product);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Products>> Delete(int Id)
        {
            Products product = productsService.GetProduct(Id).Result;
            if (product == null)
            {
                return NotFound();
            }

            await productsService.DeleteProduct(product);
            return Ok(product);
        }
    }
}