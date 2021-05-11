using System;// for IDisposable and Console.WriteLine()
using System.Collections.Generic;// for List
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;

namespace Parcels.Tests
{
[TestClass]
  public class ParcelTests : IDisposable
  {

    public void Dispose()
    {
      Parcel.ClearAll();
    }

    [TestMethod]
    public void ParcelConstructor_CreatesInstanceOfParcel_Parcel()
    {
      // Arrange
      double parcelLength = 5.5;
      double parcelWidth = 4;
      double parcelHeight = 2;
      double parcelWeight = 3.27;
      double parcelDistance = 1000;

      // Act
      Parcel newParcel = new Parcel(parcelLength, parcelWidth, parcelHeight, parcelWeight, parcelDistance);
      
      // Assert
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
      Assert.AreEqual(parcelLength, newParcel.Length);
      Assert.AreEqual(parcelWidth, newParcel.Width);
      Assert.AreEqual(parcelHeight, newParcel.Height);
      Assert.AreEqual(parcelWeight, newParcel.Weight);
      Assert.AreEqual(parcelDistance, newParcel.DistanceToDestination);
    }

    [TestMethod]
    public void Volume_CalculatesVolumeWithThreeDimensions_Double()
    {
      // Arrange
      double parcelLength = 5.5;
      double parcelWidth = 4;
      double parcelHeight = 2;
      double parcelWeight = 3.27;
      double parcelDistance = 1000;
      double output = 44;

      // Act
      Parcel newParcel = new Parcel(parcelLength, parcelWidth, parcelHeight, parcelWeight, parcelDistance);
      double result = newParcel.Volume();

      // Assert
      Assert.AreEqual(output, result);
    }

    [TestMethod]
    public void ShippingCost_CalculateShippingCostByWeightAndDistance_Double()
    {
      //Arrange
      double parcelLength = 5.5;
      double parcelWidth = 4;
      double parcelHeight = 2;
      double parcelWeight = 3.27;
      double parcelDistance = 1000;
      double output = parcelDistance * parcelWeight * .002;

      //Act
      Parcel newParcel = new Parcel(parcelLength, parcelWidth, parcelHeight, parcelWeight, parcelDistance);
      double result = newParcel.ShippingCost();

      //Assert
      Assert.AreEqual(output, result);
    }
  }
}

//NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()