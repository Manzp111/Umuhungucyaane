namespace zooproject10
{

    public class Reptile : Animal
    {
        public string Vetbrates { get; set; }
        public override void MakeNoise() => Console.WriteLine($" we are{Name}");
    }

}