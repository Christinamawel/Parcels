using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Depth { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Weight { get; set; }

    public Parcel(int depth, int length, int width, int weight)
    {
      Depth = depth;
      Length = length;
      Width = width;
      Weight = weight;
    }

    public int Volume()
    {
      int totalVolume = Depth * Length * Width;
      return totalVolume;
    }

    public int CostToShip()
    {
      int packageVolume = Volume();
      int shippingCost = packageVolume/25;
      if (Weight >= 10)
      {
        shippingCost += Weight;
      }
      return shippingCost;
    }
  }
}