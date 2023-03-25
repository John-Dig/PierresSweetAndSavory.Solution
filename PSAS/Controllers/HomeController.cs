using Microsoft.AspNetCore.Mvc;
using PSAS.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

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
        return View();
      }
      // [HttpGet("/")]
      // public async Task<ActionResult> Index()
      // {
     
      //   string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      //   ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      //   if (currentUser != null)
      //   {
      //   Item[] items = _db.Items
      //               .Where(entry => entry.User.Id == currentUser.Id)
      //               .ToArray();
      //   model.Add("items", items);
      //   }
      //   return View(model);
      // }
    }
}