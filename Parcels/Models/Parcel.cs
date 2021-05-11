using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }

    public Parcel(double length, double width, double height, double weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }

    public double Volume()
    {
      double volumeResult = Length * Width * Height;
      return volumeResult;
    }

    public static void ClearAll()
    {
      // _instances.Clear();
    }
  }
}