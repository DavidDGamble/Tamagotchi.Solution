using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests : IDisposable
  {
    public void Dispose()
    {
      Pet.ClearAll();
    }

    [TestMethod]
    public void GetAll_ReturnsItems_PetList()
    {
      Pet test = new Pet("fred");
      List<Pet> testList = new List<Pet> { test };
      CollectionAssert.AreEqual(testList, Pet.GetAll());
    }

    [TestMethod]
    public void Feed_UpdatesAllStatsAfterFeeding_List()
    {
      Pet test = new Pet("fred");
      Pet.Feed("fred");
      List<Pet> testList = new List<Pet> { test };
      List<Pet> output = Pet.GetAll();
      CollectionAssert.AreEqual(testList, output);
    }

    [TestMethod]
    public void Nap_UpdatesAllStatsAfterSleeping_List()
    {
      Pet test = new Pet("fred");
      Pet.Nap("fred");
      List<Pet> testList = new List<Pet> { test };
      List<Pet> output = Pet.GetAll();
      CollectionAssert.AreEqual(testList, output);
    }

    [TestMethod]
    public void Play_UpdatesAllStatsAfterSleeping_List()
    {
      Pet test = new Pet("fred");
      Pet.Play("fred");
      List<Pet> testList = new List<Pet> { test };
      List<Pet> output = Pet.GetAll();
      CollectionAssert.AreEqual(testList, output);
    }
  }
}