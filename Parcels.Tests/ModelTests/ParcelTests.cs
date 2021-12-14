using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Parcels.Models;

namespace Parcels.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void Volume_ReturnsVolume_64()
    {
      Parcel newParcel = new Parcel(4, 4, 4, 4);
      Assert.AreEqual(64, newParcel.Volume());
    }
    [TestMethod]
    public void CostToShip_ReturnsTotalShippingCost_12()
    {
      Parcel newParcel = new Parcel(4, 4, 4, 10);
      Assert.AreEqual(12, newParcel.CostToShip());
    }
  }
}