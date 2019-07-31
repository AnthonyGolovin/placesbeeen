using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using System.Collections.Generic;

namespace Travel.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string city, string description)
    {
      Place myPlace = new Place(city, description);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }

    [HttpGet("/places/newest")]
    public ActionResult Newest()
    {
      return View();
    }
    [HttpGet("/places/deeper")]
    public ActionResult DeeperDungeonHole()
    {
      return View();
    }
  }
}