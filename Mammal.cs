namespace zooproject10;

    public class Mammal : Animal
    {
        public string FurType { get; set; }
        public override void MakeNoise() => Console.WriteLine($" we are{Name}");
    }

    
