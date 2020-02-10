using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApi.Entities;
using FirstApi.Provider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("api/MyFirstcon")]
    public class MyFrstController : ControllerBase
    {
       [Route("First")]
       [HttpGet]
        public string FirstAction(string Name,int Age)
        {
            return $"My name is {Name} and iam {Age} years old";
        }
        [Route("Second")]
        [HttpGet]
        public string Second()
        {
            return "my name is bhanu";
        }
        [Route("Adding")]
        [HttpGet]
        public string AddCat()
        {
            CatageoryDbcon catageory = new CatageoryDbcon();
            Category cat = new Category();
            cat.CategoryName = "Veg";
            cat.CategoryDetails = "Pure Veg";
            catageory.Categories.Add(cat);
            catageory.SaveChanges();
            return "Added";
        }
    }
}
