using Microsoft.AspNetCore.Mvc;
using PSAS.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using PSAS.ViewModels;


namespace PSAS.Controllers
{
  public class HomeController : Controller
  {
    private readonly PSASContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser> userManager, PSASContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Flavor> allFlavors = _db.Flavors.ToList();
      List<Treat> allTreats = _db.Treats.ToList();
      MenuViewModel viewModel = new MenuViewModel
      {
        AllFlavors = allFlavors,
        AllTreats = allTreats
      };
      return View(viewModel);
    }

  }
}