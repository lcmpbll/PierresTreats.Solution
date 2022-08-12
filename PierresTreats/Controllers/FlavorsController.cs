using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

[Authorize]
namespace PierresTreats.Controllers
{
  public class FlavorController : Controller
  {
    private readonly PierresTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public FlavorController(UserManager<ApplicationUser> userManager, PierresTreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    { var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userFlavor = _db.Flavors.Where(entry => entry.User.Id == currentUser.Id).ToList();
      // List<Flavor> model = _db.Flavors.Include(flavor => flavor.Treat).ToList();
      return View(userFlavor);
    }
    
    public ActionResult Create()
    {
      return View();
    }
    
    [HttpPost]
    public async Task<ActionResult> Create(Flavor flavor, int TreatId)
    {
      var userId =  this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
        flavor.User = currentUser;
        _db.Flavors.Add(flavor);
        _db.SaveChanges();
        if (TreatId != 0 )
        {
          _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}