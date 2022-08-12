using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

[Authorize]
namespace ProjectName.Controllers
{
  public class ClassOneController : Controller
  {
    private readonly ProjectNameContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public ClassOneController(UserManager<ApplicationUser> userManager, ProjectNameContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    { var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userClassOne = _db.ClassOnes.Where(entry => entry.User.Id == currentUser.Id).ToList();
      // List<ClassOne> model = _db.ClassOnes.Include(classOne => classOne.ClassTwo).ToList();
      return View(userClassOne);
    }
    
    public ActionResult Create()
    {
      return View();
    }
    
    [HttpPost]
    public async Task<ActionResult> Create(ClassOne classOne, int ClassTwoId)
    {
      var userId =  this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
        classOne.User = currentUser;
        _db.ClassOnes.Add(classOne);
        _db.SaveChanges();
        if (ClassTwoId != 0 )
        {
          _db.ClassOneClassTwo.Add(new ClassOneClassTwo() { ClassTwoId = ClassTwoId, ClassOneId = classOne.ClassOneId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}