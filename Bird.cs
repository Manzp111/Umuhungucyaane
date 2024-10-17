namespace zooproject10
{

     public class Bird : Animal
     {
          public double Wingspan { get; set; }
          public override void MakeNoise() => Console.WriteLine($" we are{Name}");
          
     }

}