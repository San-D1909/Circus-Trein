﻿using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestCircusTrein
{
    [TestClass]
    public class UnitTestCircusTrein
    {
        private Train train = new Train { };
        private List<Wagon> wagons = new List<Wagon> { };
        Wagon wagon = new Wagon { Wagon_Number = 0 };
        private readonly Animal lion = new Animal { diet = Animal.Diet.Carnivours, Name = "Lion", weight = Animal.Weight.Large };
        private readonly Animal giraffe = new Animal { diet = Animal.Diet.Herbivours, Name = "giraffe", weight = Animal.Weight.Large };
        private readonly Animal cat = new Animal { diet = Animal.Diet.Carnivours, Name = "cat", weight = Animal.Weight.Small };
        [TestMethod]
        public void CreateAnimals()
        {
            List<Animal> animals = train.CreateAnimalsList(100);
            Assert.IsTrue(animals.Count == 100);
        }
        [TestMethod]
        public void CreateAnimal()
        {
            Animal wolf = train.CreateAnimal(0, 1, 1);
            Assert.IsTrue(wolf.weight == Animal.Weight.Medium && wolf.diet == Animal.Diet.Carnivours);
        }
        [TestMethod]
        public void CreateWagons()
        {
            for (int i = 0; i < 10; i++)
            {
                wagons.Add(new Wagon { Wagon_Number = wagons.Count });
            }
            Assert.IsTrue(wagons.Count == 10);
        }
        [TestMethod]
        public void SameSizeAnimals()
        {
            wagon.AddToWagon(lion);
            Assert.IsFalse(wagon.CheckIfSafe(giraffe));
        }
        [TestMethod]
        public void SmallCarnivorousWithBigHerbivore()
        {
            wagon.AddToWagon(cat);
            Assert.IsTrue(wagon.AddToWagon(giraffe));
        }
        [TestMethod]
        public void CheckIfSpace()
        {
            wagon.AddToWagon(giraffe);
            wagon.AddToWagon(cat);
            Assert.IsFalse(wagon.CheckIfSpace(giraffe));
        }
    }
}
