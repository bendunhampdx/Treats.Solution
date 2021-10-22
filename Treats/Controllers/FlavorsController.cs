using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Treats.Models;
using System.Collections.Generic;
using System.Linq;

namespace Treats.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly TreatsContext _db;

    public FlavorsController(TreatsContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }
  }
}