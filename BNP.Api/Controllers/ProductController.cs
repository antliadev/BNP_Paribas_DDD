using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BNP.Domain.Entities;
using BNP.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BNP.Api.Controllers
{   
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [Route("v1/Product/FetchProducts")]
        [HttpGet]
        public IEnumerable<Product> FetchProducts()
        {
            return _productService.FetchProduct();
        }

        [Route("v1/Product/Save")]
        [HttpPost]
        public ActionResult<dynamic> Save([FromBody]ProductRegister model)
        {
            Product obj = new Product();
            obj.IdCategory = 1;
            obj.Description = model.description;
            obj.Active = true;

            _productService.AddProduct(obj);

            return new
            {
                user = "",
                role = "",
                date = "",
                token = "",
            };
        }

        [Route("v1/Product/FetchProductById")]
        [HttpGet]
        public Product FetchProductById(int Id)
        {
            return _productService.FetchGroupsById(Id);
        }

        [Route("v1/Product/UpdateStatus")]
        [HttpPut]
        public void UpdateStatus(int Id, [FromBody]Product model)
        {
            _productService.UpdateStatusGroups(Id, model.Active);
        }

        [Route("v1/Product/Update")]
        [HttpPut]
        public void Update(int Id, [FromBody]Product model)
        {
            _productService.UpdateGroups(Id, model);
        }

        [Route("v1/Product/Delete")]
        [HttpDelete]
        public void Delete(int Id)
        {
            _productService.DeleteGroups(Id);
        }

        public class ProductRegister
        {   
            public string description { get; set; }         
        }
    }
}