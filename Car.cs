using System;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel;
    public string CarInfo;
    public int Price;
    public int Miles;

    public Car(string makeModel, string carInfo, int price, int miles)
    {
      MakeModel = makeModel;
      CarInfo = carInfo;
      Price = price;
      Miles = miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }
    public bool WorthMiles(int maxMiles)
    {
      return (Miles < maxMiles);
    }
  }
}
