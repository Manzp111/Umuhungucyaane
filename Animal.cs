namespace zooproject10
{

    public abstract class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public abstract void MakeNoise();
    }
}