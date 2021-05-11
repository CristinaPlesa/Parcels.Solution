using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Parcel starterParcel = new Parcel("Add first Parcel to Shipping list");
      return View(starterParcel);
    }
  }
}