using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetMission
{
    internal class Venus : PlanetMission
    {
        public Venus()
        {
            kmToPlanet = 41_000_000;
            fuelPerKm = 2.11f;
            kmPerHour = 29500;
        }
    }
}
