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
        public string FirstAction(string Name, int Age)
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

            Category cat1 = new Category();
            cat1.CategoryName = "Hot Drincks";
            cat1.CategoryDetails = "Tea";
            catageory.Categories.Add(cat1);

            Category cat2 = new Category();
            cat2.CategoryName = "Non Veg";
            cat2.CategoryDetails = "Pure Non Veg";
            catageory.Categories.Add(cat2);

            Category cat3 = new Category();
            cat3.CategoryName = "Main Course";
            cat3.CategoryDetails = "Biriyani";
            catageory.Categories.Add(cat3);

            Category cat4 = new Category();
            cat4.CategoryName = "Cool Drincks";
            cat4.CategoryDetails = "Pepsi,Mountain Due";
            catageory.Categories.Add(cat4);

            catageory.SaveChanges();
            return "Added";
        }
        [Route("GetAllDetails")]
        [HttpGet]
        public List<Category> GetDetailsI()
        {
            CatageoryDbcon catageory = new CatageoryDbcon();
            return catageory.Categories.ToList();
        }
        [Route("GetById")]
        [HttpGet]
        public List<Category> GetId(int id)
        {
            CatageoryDbcon catageory = new CatageoryDbcon();
            return catageory.Categories.Where(i => i.Id == id).ToList();
        }
        [Route("Update")]
        [HttpPut]
        public string UpdateDetails(int id,Category obj)
        {
            CatageoryDbcon catageory = new CatageoryDbcon();
          var gh =  catageory.Categories.Where(i => i.Id == id).FirstOrDefault();
            gh.CategoryName = obj.CategoryName;
            catageory.SaveChanges();
            return "Updated Sucessfully";
        }
        [Route("Delete")]
        [HttpDelete]
        public string DeleteDetails(int id)
        {
            CatageoryDbcon catageory = new CatageoryDbcon();
            var gh = catageory.Categories.Where(i => i.Id == id).FirstOrDefault();
            catageory.Categories.Remove(gh);
            catageory.SaveChanges();
            return "Deleted Sucessfully";
        }
    }
}
