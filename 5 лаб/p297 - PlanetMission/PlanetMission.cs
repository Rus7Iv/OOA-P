using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p297___PlanetMission
{
    abstract class PlanetMission
    {
        public abstract void SetMissionInfo(
            int milesToPlanet, 
            long rocketFuelPerMile, 
            long rocketSpeedMPH);
        public long RocketFuelPerMile;
        public long RocketSpeedMPH;
        public int MilesToPlanet; 

        public long UnitsOfFuelNeeded()
        {
            return MilesToPlanet * RocketFuelPerMile;
        }

        public int TimeNeeded()
        {
            return MilesToPlanet / (int)RocketSpeedMPH;
        }

        public string FuelNeeded()
        {
            return "You’ll need "
              + MilesToPlanet * RocketFuelPerMile
              + " units of fuel to get there. It’ll take "
              + TimeNeeded() + " hours.";
        }
    }
}