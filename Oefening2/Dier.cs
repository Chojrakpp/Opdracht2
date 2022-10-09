using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    public abstract class Dier
    {
        public int gewicht { get; set; }
        protected string uitspraak { get; set; }
        protected string geluid { get; set; }

        public Dier()
        {
            gewicht = 0;
            uitspraak = "onbekend klank";
            geluid = "geen geluid";
        }

        public String Zegt()
        {
            return uitspraak;
        }
    }
}
