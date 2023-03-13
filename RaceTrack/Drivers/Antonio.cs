using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Antonio : Driver
    {
        public Antonio(RaceCar car) : base(car)
        {
            Name = "Antonio";
            SkillLevel = 10;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
