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
            List<Animal> animals = Animal.Create_Animals_List(100);
            Assert.IsTrue(animals.Count == 100);
        }
        [TestMethod]
        public void Create_Wagons()
        {
            List<Wagon> wagons = new List<Wagon> { };
            for (int i = 0; i < 10; i++)
            {
                wagons = Wagon.Create_Wagons(wagons);
            }
            Assert.IsTrue(wagons.Count == 10);
        }
        [TestMethod]
        public void Check_If_Safe_For_Same_Size_Animals()
        {
            Animal lion = Animal.Create_Animal(0, 2, 1);
            Animal giraffe = Animal.Create_Animal(1, 2, 0);
            Wagon wagon = new Wagon { Free_Space = 10, Wagon_Number = 0 };
            Wagon.Add_To_Wagon(lion, wagon);
            Assert.IsFalse(Wagon.Check_If_Safe(giraffe, wagon));
        }
        [TestMethod]
        public void Check_Small_Carnivorous_With_Big_Herbivore()
        {
            Animal cat = Animal.Create_Animal(0, 0, 1);
            Animal giraffe = Animal.Create_Animal(1,2, 0);
            Wagon wagon = new Wagon { Free_Space = 10, Wagon_Number = 0 };
            Wagon.Add_To_Wagon(cat, wagon);
            Assert.IsTrue(Wagon.Add_To_Wagon(giraffe, wagon));
        }
    }
}
