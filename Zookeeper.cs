using System;
using System.Collections.Generic; 
namespace zooproject10;

public class Zookeeper
{
    public string Name { get; set; }
    public string Specialization { get;set; }
    public List<Enclosure> Enclosures { get; } = new List<Enclosure>();
    public void AssignEnclosure(Enclosure enclosure) => Enclosures.Add(enclosure);
    public void RemoveEnclosure(Enclosure enclosure) => Enclosures.Remove(enclosure);
}
