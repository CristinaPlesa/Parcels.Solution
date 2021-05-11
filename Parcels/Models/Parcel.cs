using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double DistanceToDestination { get; set; }

    public Parcel(double length, double width, double height, double weight, double distance)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      DistanceToDestination = distance;
    }

    public double Volume()
    {
      double volumeResult = Length * Width * Height;
      return volumeResult;
    }

    public double ShippingCost()
    {
      double cost = Weight * DistanceToDestination * .002;
      return cost;
    }

    public static void ClearAll()
    {
      // _instances.Clear();
    }
  }
}