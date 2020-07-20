using System;

namespace WeekdayFinder.Models
{
  public class WeekdayFinderClass
  {
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public string DayOfWeek()
    {
      DateTime newDateTime = new DateTime(Year, Month, Day);
      return newDateTime.DayOfWeek.ToString();
    }
  } 
}