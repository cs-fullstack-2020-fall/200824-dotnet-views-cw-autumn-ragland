using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Classwork.Controllers
{
    public class Cat : Controller
    {
         public List<CatObject> catList = new List<CatObject>(){new CatObject("Princess", "Calico", 8), new CatObject("Eddie", "Stray", 3), new CatObject("Muffin", "Ragdoll", 10)};
         
         public IActionResult ViewAll()
         {
             ViewData["catList"] = catList;
             return View();
         }
         public IActionResult ViewOne(string catName)
         {
             CatObject foundCat = catList.FirstOrDefault(cat => cat.name == catName);
             if(foundCat.name != null)
             {
                 ViewData["name"] = foundCat.name;
                 ViewData["age"] = foundCat.age;
                 ViewData["breed"] = foundCat.breed;
                return View(); 
             } else
             {
                 return View("PetNotFound");
             }
         }
         [HttpPost]
         public IActionResult CreateOne(string name, string breed, int age)
         {
             CatObject newCat = new CatObject(name, breed, age);
             catList.Add(newCat);
             ViewData["catList"] = catList;
             return View("ViewAll");
         }
    }
}
public struct CatObject 
{      
    public string name;
    public string breed;
    public int age;
    public CatObject(string name, string breed, int age)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;
    }
}