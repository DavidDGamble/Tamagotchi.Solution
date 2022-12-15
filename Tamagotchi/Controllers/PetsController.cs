using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Controllers
{

  public class PetsController : Controller
  {
    [HttpGet("/pets")]
    public ActionResult Index()
    {
      List<Pet> allPets = Pet.GetAll();
      return View(allPets);
    }

    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pets")]
    public ActionResult Create(string name)
    {
      Pet pet = new Pet(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/pets/{name}")]
    public ActionResult Show(string name)
    {
      Pet foundPet = Pet.Find(name);
      return View(foundPet);
    }
    
    [HttpPost("/pets/{name}")]
    public ActionResult Update(string name, string place)
    {
      if (place == "feed")
      {
        Pet.Feed(name);
      }
      else if (place == "play")
      {
        Pet.Play(name);
      }
      else if (place == "sleep")
      {
        Pet.Nap(name);
      }
      return RedirectToAction("Index");
    }
  }
}