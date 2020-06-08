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
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _categoryService;

        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Route("v1/Category/FetchCategory")]
        [HttpGet]
        public IEnumerable<Category> FetchCategory()
        {
            return _categoryService.FetchCategory();
        }

        [Route("v1/Category/Save")]
        [HttpPost]
        public ActionResult<dynamic> Save([FromBody]Category model)
        {
            Category obj = new Category();            
            obj.Description = "Teste Prod " + DateTime.Now.ToString();
            obj.Active = model.Active;

            _categoryService.AddCategory(obj);

            return new
            {
                user = "",
                role = "",
                date = "",
                token = "",
            };
        }
    }
}