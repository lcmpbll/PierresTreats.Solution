using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierresTreats.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace PierresTreats.controller
{
  public class HomeController : Controller
  {
    private readonly PierresTreatsContext _db;
    public HomeController(PierresTreatsContext db)
    {
      _db = db;
    }
    
    [AllowAnonymous]
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Title = "Pierre's Sweets and Treats";
      ViewBag.Subtitle = "Savory and Sweet For Any Moment";
      ViewBag.FlavorTreat = _db.FlavorTreat;
      return View();
    }
  }
}