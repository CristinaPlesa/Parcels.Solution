using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Parcel starterParcel = new Parcel(1, 1, 1, 1, 100);
      return View(starterParcel);
    }
  }
}