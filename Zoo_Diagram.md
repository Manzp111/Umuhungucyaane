                
                                 Zoo diagram
```mermaid
classDiagram
class Zookeper{
   String Name
   String Specialization
 }
 class Animal {
   String Name
   String Species
   int Age
   
   }
 class Mammal{
   String: Name
   String Species
   int Age
   String FurType
  }
class Birds{
   String Name
   String Species
   int Age
   String Wingspan
  }
class Reptile{
   String Name
   String Species
   int Age
   String vertblate
  }
class Enclosures{
   String Name
   int Size
   String Enironment type 
   
  }

 class Zoo {
 Mammal
 Birds
 Reptile
 Enclosures
 Zookeper
 
 }
 Zoo -->Enclosures
Zoo -->Zookeper
Zoo -->Animal
Animal --> Birds
Animal --> Mammal
Animal --> Reptile





