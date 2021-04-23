using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        public int Wagon_Number { get; set; }
        public int Free_Space { get; set; }
        private List<Animal> animals { get; set; } = new List<Animal>();
        public List<Animal> Animals { get { return animals; } }
        public override string ToString()
        {
            return "Wagon Number: " + Wagon_Number + "    Animals: " + Animals.Count + "  Free Space: " + Free_Space;
        }

    }
}
