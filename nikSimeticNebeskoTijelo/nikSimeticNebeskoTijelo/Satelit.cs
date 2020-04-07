using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticNebeskoTijelo
{
    class Satelit : NebeskoTijelo
    {
        public Satelit(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi = brzinaOkoOsi;
            BrzinaOkoSunca = brzinaOkoSunca;
        }
    }
}
