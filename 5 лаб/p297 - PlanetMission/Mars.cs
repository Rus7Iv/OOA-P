using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p297___PlanetMission
{
    class Mars : PlanetMission
    {
        public Mars()
        {
            SetMissionInfo(75000000, 100000, 25000);
            /*MilesToPlanet = 75000000;
            RocketFuelPerMile = 100000;
            RocketSpeedMPH = 25000; */
        }

        public override void SetMissionInfo(int milesToPlanet, long rocketFuelPerMile, long rocketSpeedMPH)
        {
            this.MilesToPlanet = milesToPlanet;
            this.RocketFuelPerMile = rocketFuelPerMile;
            this.RocketSpeedMPH = rocketSpeedMPH;
        }
    }
}
