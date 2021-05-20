using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        public string Name { get; set; }
        public Weight weight { get; set; }
        public enum Weight
        {
            Large = 5,
            Medium = 3,
            Small = 1
        }
        public Diet diet { get; set; }
        public enum Diet
        {
            Herbivours,
            Carnivours
        }
    }
}

