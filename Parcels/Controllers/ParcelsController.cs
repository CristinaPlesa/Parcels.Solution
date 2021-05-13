using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/home")]
    public ActionResult Index()
    {
      // double shippingCost = Parcel.ShippingCost();
      return View();
    }

    [HttpGet("/home/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/home")]
    public ActionResult Create(double length, double width, double height, double weight, double distance )
    {
      Parcel myParcel = new Parcel(length, width, height, weight, distance);
      double shippingCost = myParcel.ShippingCost();
      return RedirectToAction("Index");
    }

  }
}