using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CretaceousClient.Models;
using Microsoft.EntityFrameworkCore;


namespace CretaceousClient.Controllers
{
  public class AnimalsController : Controller
    {
      public IActionResult Index()
      {
        var allAnimals = Animal.GetAnimals();
        return View(allAnimals);
      }

    }
}