using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Classwork.Controllers
{
    public class Dog : Controller
    {
         public List<DogObject> dogList =  new List<DogObject>(){new DogObject("Fido", "Mutt", 7), new DogObject("Dakota", "Terrier", 3), new DogObject("Fluffy", "Poodle", 1)};
         
         public IActionResult ViewAll()
         {
             ViewData["dogList"] = dogList;
             return View();
         }
         public IActionResult ViewOne(string dogName)
         {
             DogObject foundDog = dogList.FirstOrDefault(dog => dog.name == dogName);
             if(foundDog.name != null)
             {
                 ViewData["name"] = foundDog.name;
                 ViewData["age"] = foundDog.age;
                 ViewData["breed"] = foundDog.breed;
                return View(); 
             } else
             {
                 return View("PetNotFound");
             }
         }
         [HttpPost]
         public IActionResult CreateOne(string name, string breed, int age)
         {
             DogObject newDog = new DogObject(name, breed, age);
             dogList.Add(newDog);
             ViewData["dogList"] = dogList;
             return View("ViewAll");
         }
    }
}
public struct DogObject 
{      
    public string name;
    public string breed;
    public int age;
    public DogObject(string name, string breed, int age)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;
    }
}