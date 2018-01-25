using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {




            var thegalaxies = new List<Galaxy>
            {
                                new Galaxy() { Name ="Tadpole", MegaLightYears=400},
new Galaxy() { Name ="Pinwheel", MegaLightYears=25},
                new Galaxy() { Name ="Milky Way", MegaLightYears=0},
                new Galaxy() {Name= "Andromeda", MegaLightYears=3}
            };


            {
                foreach (Galaxy thegalaxy in thegalaxies)
                {
                    Console.WriteLine(thegalaxy.Name + " " + thegalaxy.MegaLightYears);
                }

                Console.ReadLine();

            }
        }

        public class Galaxy
        {
            public string Name { get; set; }
            public int MegaLightYears { get; set; }
        }
    }
}
