using RaceTrack.RaceTrack.Cars;

namespace DotNetA8.RaceTrack.Cars
{
    public class ToyotaTacoma : RaceCar
    {
        public ToyotaTacoma()
        {
            Name = "Toyota Tacoma";
            TopSpeed = 85;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} cranks a few times before it starts");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} sputters as the engine is turned off");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} locks the tires as it slows down!");
            base.Brake();
        }
    }
}
