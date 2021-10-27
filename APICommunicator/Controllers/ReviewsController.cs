using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelAPIClient.Models;

namespace TravelAPIClient.Controllers
{
  public class ReviewsController : ControllerBase
  {
    [HttpGet("/")]
    public IActionResult Index()
    {
      var allReviews = Review.GetReviews();
      return View(allReviews);
    }
  }
}