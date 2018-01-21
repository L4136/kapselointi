using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oliojaluokka
{ using System;

namespace CarApplication
{ 

    class cprogram
    {
        static void Main(string[] args)
        {
            // create a cd instance
            Cd endless = new Cd();
            endless.Artist = "Nightwish";
            endless.Name = "Endless Forms Most Beautiful";
            endless.Genre = "Symphonic metal";
            endless.Price = 19.9;
            // display cd data
            endless.PrintData();
        }
    }
}
}