using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1964 Volkswagen", "Luxury and classic car", 1100, 367838);
      Car yugo = new Car("1980 Yugo Koral", "Modern and stabel car", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", "Friendly and reliable car", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", "Cost effective and trustworthy car", 400, 198000);

      List<Car> Cars = new List<Car>() {volkswagen, yugo, ford, amc};

      Console.WriteLine("Enter maxinum price: ");
      int.TryParse(Console.ReadLine(), out int maxPrice);
      Console.WriteLine("Enter mixunum miles: ");
      int.TryParse(Console.ReadLine(), out int maxMiles);

      List<Car> CarsMatchingSearch = new List<Car>();

      foreach(Car automobile in Cars)
        {
          if (automobile.WorthBuying(maxPrice) && automobile.WorthMiles(maxMiles))
          {
            CarsMatchingSearch.Add(automobile);
          }
        }


      if (CarsMatchingSearch.Count < 1)
      {
        Console.WriteLine("Sorry, no cars match the budget constraint");
      }
      else
      {
      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.MakeModel + ", " + automobile.CarInfo);
      }
      }
    }
  }
}
