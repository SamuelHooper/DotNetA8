using RaceTrack.RaceTrack.Cars;
using RaceTrack.RaceTrack.Drivers;

namespace DotNetA8.RaceTrack.Drivers
{
    public class Samuel : Driver
    {
        public Samuel(RaceCar car) : base(car)
        {
            Name = "Samuel";
            SkillLevel = 8;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
