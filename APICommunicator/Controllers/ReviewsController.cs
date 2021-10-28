using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using TravelAPIClient.Models;

namespace TravelAPIClient.Controllers
{
  public class ReviewsController : Controller
  {
    public IActionResult Index()
    {
      var allReviews = Review.GetReviews();
      return View(allReviews);
    }

    [HttpPost]
    public IActionResult Index(Review review)
    {
      System.Console.WriteLine("Username: " + review.User);
      System.Console.WriteLine("Country: " + review.Country);
      Review.Post(review);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var review = Review.GetDetails(id);
      return View(review);
    }

    public IActionResult Edit(int id)
    {
      var review = Review.GetDetails(id);
      return View(review);
    }

    [HttpPost]
    public IActionResult Details(int id, Review review)
    {
      review.ReviewId = id;
      Review.Put(review);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Review.Delete(id);
      return RedirectToAction("Index");
    }
  }
}