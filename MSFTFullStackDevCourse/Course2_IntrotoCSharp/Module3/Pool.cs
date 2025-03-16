using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2_IntrotoCSharp.Module3
{
    public class Pool
    {
        public int chlorineLevel;
        public int waterLevel;

        public Pool(int chlorine, int water) // Constructor
        {
            chlorineLevel = chlorine;
            chlorineLevel = chlorine;
            waterLevel = water;
        }

        public void PoolInfo()
        {
            Console.WriteLine("Chlorine Level: " + chlorineLevel);
            Console.WriteLine("Water Level: " + waterLevel);
        }
    }

    public class Spa : Pool
    {
        public int heatLevel; // note we're not re-declaring the chrloineLevel and waterLevel variables, because we're inheriting those from the parent class
        public Spa(int chlorine, int water, int heat) :base (chlorine, water)
        {
           
            heatLevel = heat;

        }
        public void PoolInfo() //overloading the original method name
        {
            Console.WriteLine("Chlorine Level: " + chlorineLevel);
            Console.WriteLine("Water Level: " + waterLevel);
            Console.WriteLine("Heat Level: " + heatLevel);
        }
    }
}
