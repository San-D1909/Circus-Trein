using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CircusTrein;
using System.Collections.Generic;

namespace UnitTest_CircusTrein
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Create_Animals()
        {
            List<Animal> animals = AnimalMethods.Create_Animals_List(100);
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
        public void Check_If_Safe_For_Same_Size_Animals()
        {
            Animal lion = new Animal {Carnivorous= true, Name = "Lion", Weight = 5 };
            Animal giraffe = new Animal { Carnivorous = false, Name = "giraffe", Weight = 5 };
            Wagon wagon = new Wagon { Free_Space = 10, Wagon_Number = 0 };
            WagonMethods.Add_To_Wagon(lion, wagon);
            Assert.IsFalse(WagonMethods.Check_If_Safe(giraffe, wagon));
        }
        [TestMethod]
        public void Check_Small_Carnivorous_With_Big_Herbivore()
        {
            Animal cat = new Animal { Carnivorous = true, Name = "cat", Weight = 1 };
            Animal giraffe = new Animal { Carnivorous = false, Name = "giraffe", Weight = 5 };
            Wagon wagon = new Wagon { Free_Space = 10, Wagon_Number = 0 };
            WagonMethods.Add_To_Wagon(cat, wagon);
            Assert.IsTrue(WagonMethods.Add_To_Wagon(giraffe, wagon));
        }
    }
}
