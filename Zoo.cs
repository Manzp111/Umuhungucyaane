

using System;
using System.Collections.Generic;
namespace zooproject10;

public class Zoo
{
    public List<Animal> Animals { get; } = new List<Animal>();
    public List<Enclosure> Enclosures { get; } = new List<Enclosure>();
    public List<Zookeeper> Zookeepers { get; } = new List<Zookeeper>();
    public void AddAnimal(Animal animal) => Animals.Add(animal);
    
    public void RemoveAnimal(Animal animal) => Animals.Remove(animal);
    public void CreateEnclosure(Enclosure enclosure) => Enclosures.Add(enclosure);
    public void RemoveEnclosure(Enclosure enclosure) => Enclosures.Remove(enclosure);
    public void HireZookeeper(Zookeeper zookeeper) => Zookeepers.Add(zookeeper);
    public void AssignAnimalToEnclosure(Animal animal, Enclosure enclosure) => enclosure.AddAnimal(animal);
    public void RemoveAnimalFromEnclosure(Animal animal, Enclosure enclosure) => enclosure.RemoveAnimal(animal);

    public void SimulateDay()
    {
        Console.WriteLine("\n----- Simulating a Day at the Zoo -----");
        Animals.ForEach(a => a.MakeNoise());
        Console.WriteLine("Zookeepers are feeding the animals...");
    }
}
