using Microsoft.AspNetCore.Mvc;
using WeekdayFinder.Models;

namespace WeekdayFinder.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult DateForm() { return View(); }

    [Route("/weekday")]
    public ActionResult Weekday(string day, string month, string year)
    {
      int dayInput = int.Parse(day);
      int monthInput = int.Parse(month);
      int yearInput = int.Parse(year);
      WeekdayFinderClass finder = new WeekdayFinderClass();
      finder.Day = dayInput;
      finder.Month = monthInput;
      finder.Year = yearInput;
      return View(finder);
    } 
  }
}