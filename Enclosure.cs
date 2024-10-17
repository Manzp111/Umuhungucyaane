using System;
using System.Collections.Generic;
namespace zooproject10
{ 
    public class Enclosure 
    { 
        public string Name { get; set; }
        public double Size { get; set; } 
        public string EnvironmentType { get; set; }
        public List<Animal> Animals { get; } = new List<Animal>(); //list of animal in encolosures
        public void AddAnimal(Animal animal) => Animals.Add(animal); //method of adding animal   
        public void RemoveAnimal(Animal animal) => Animals.Remove(animal); // method of removing animal
    }

}