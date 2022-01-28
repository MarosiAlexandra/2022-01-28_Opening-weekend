using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_01_28_Opening_weekend
{
    class Film
    {
        public string eredetiCim { get; set; }
        public string magyarCim { get; set; }
        public string bemutato { get; set; }
        public string forgalmazo { get; set; }
        public int bevétel { get; set; }
        public int látogatók { get; set; }

        public Film(string sor)
        {
            string[] t = sor.Split(';');
            eredetiCim = t[0];
            magyarCim = t[1];
            bemutato = t[2];
            forgalmazo = t[3];
            bevétel = int.Parse(t[4]);
            látogatók= int.Parse(t[5]);


        }
    }
}
