using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/TotalCost")]
    public ActionResult TotalCost(int depth, int length, int width, int weight)
    {
      Parcel newParcel = new Parcel(depth, length, width, weight);
      return View(newParcel);
    }
  }
}