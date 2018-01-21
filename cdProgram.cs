using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oliojaluokka
{
    class Cd
    {
            // properties
            public string Artist { get; set; }
            public string Name { get; set; }
            public string Genre { get; set; }
            public double Price { get; set; }
            

        // method to display cd data
        public void PrintData()
        {
            Console.WriteLine("CD Data : ");
            Console.WriteLine("- artist : " + Artist);
            Console.WriteLine("- name : " + Name);
            Console.WriteLine("- genre : " + Genre);
            Console.WriteLine("- price : " + Price );

        }

    }
}
   