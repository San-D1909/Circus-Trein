using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestCircusTrein
{
    [TestClass]
    public class UnitTestCircusTrein
    {
        [TestMethod]
        public void Create_Animals()
        {
            Train train = new Train { };
            List<Animal> animals = train.CreateAnimalsList(100);
            Assert.IsTrue(animals.Count == 100);
        }
        [TestMethod]
        public void Create_Wagons()
        {
            List<Wagon> wagons = new List<Wagon> { };
            for (int i = 0; i < 10; i++)
            {
                wagons.Add(new Wagon { Wagon_Number = wagons.Count });
            }
            Assert.IsTrue(wagons.Count == 10);
        }
        [TestMethod]
        public void SameSizeAnimals()
        {
            Animal lion = new Animal {diet= Animal.Diet.Carnivours, Name = "Lion", weight = Animal.Weight.Large };
            Animal giraffe = new Animal { diet = Animal.Diet.Herbivours, Name = "giraffe", weight = Animal.Weight.Large };
            Wagon wagon = new Wagon {  Wagon_Number = 0 };
            wagon.AddToWagon(lion);
            Assert.IsFalse(wagon.CheckIfSafe(giraffe));
        }
        [TestMethod]
        public void SmallCarnivorousWithBigHerbivore()
        {
            Animal cat = new Animal { diet = Animal.Diet.Carnivours, Name = "cat", weight = Animal.Weight.Small };
            Animal giraffe = new Animal { diet = Animal.Diet.Herbivours, Name = "giraffe", weight = Animal.Weight.Large };
            Wagon wagon = new Wagon {  Wagon_Number = 0 };
            wagon.AddToWagon(cat);
            Assert.IsTrue(wagon.AddToWagon(giraffe));
        }
    }
}
