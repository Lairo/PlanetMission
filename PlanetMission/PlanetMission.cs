using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetMission
{
    abstract class PlanetMission
    {
        protected float fuelPerKm;
        protected long kmPerHour;
        protected long kmToPlanet;

        public string MissionInfo()
        {
            long fuel = (long)(kmPerHour * fuelPerKm);
            long time = kmToPlanet / kmPerHour;
            return $" We'll burn {fuel} units of fuel in {time} hours";
        }
    }
}
