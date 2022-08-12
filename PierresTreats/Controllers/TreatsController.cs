using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierresTreats.Controllers
{
  // public class TreatController : Controller
  // {
  //   private readonly PierresTreatsContext _db;

  //   public TreatController(PierresTreatsContext db)
  //   {
  //     _db = db;
  //   }

  //   public ActionResult Index()
  //   {
  //     List<Treat> model = _db.Treat.ToList();
  //     return View(model);
  //   }
  // }
}