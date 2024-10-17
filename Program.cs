using System;

namespace zooproject10; //program to manage zoo project
class Program
{
    static Zoo zoo = new Zoo();
    
    static void ShowMenu() 
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("1. Add Animal to Zoo");
        Console.WriteLine("2. Create Enclosure");
        Console.WriteLine("3. Remove Enclosure");
        Console.WriteLine("4. Assign Animal to Enclosure");
        Console.WriteLine("5. Remove Animal from Enclosure");
        Console.WriteLine("6. Hire Zookeeper");
        Console.WriteLine("7. Assign Zookeeper to Enclosure");
        Console.WriteLine("8. Simulate a Day at the Zoo");
        Console.WriteLine("9. Remove Animal from Zoo"); 
        Console.WriteLine("10. Exit");
        Console.Write("Choose an option: ");
    }

    static int GetMenuChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 10)
        {
            Console.Write("Invalid choice. Try again: ");
        }
        return choice;
    }

    static void AddAnimal()
    {
        Console.Clear();
        Console.Write("Write animal name: ");
        string name = Console.ReadLine();
        Console.Write("Write species: ");
        string species = Console.ReadLine();
        Console.Write("Write  age: ");
        int age = int.Parse(Console.ReadLine());

        Animal animal = new Mammal { Name = name, Species = species, Age = age };
        zoo.AddAnimal(animal);

        Console.WriteLine($"{animal.Name} added to the to animals. Press Enter to continue...");
        Console.ReadLine();
    } 
    static void CreateEnclosure()
    {
        Console.Clear();
        Console.Write("Write enclosure name: ");
        string name = Console.ReadLine();
        Console.Write(" Write the size: ");
        double size = double.Parse(Console.ReadLine());
        Console.Write("Write environment type: ");
        string environmentType = Console.ReadLine();

        Enclosure enclosure = new Enclosure { Name = name, Size = size, EnvironmentType = environmentType };
        zoo.CreateEnclosure(enclosure);

        Console.WriteLine($"Enclosure '{name}' created. Press Enter to continue...");
        Console.ReadLine();
    }

    static void RemoveEnclosure()
    {
        Console.Clear();
        if (zoo.Enclosures.Count == 0)
        {
            Console.WriteLine("No enclosures to remove.");
            return;
        }

        Console.WriteLine("Select an enclosure to remove:");
        for (int i = 0; i < zoo.Enclosures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {zoo.Enclosures[i].Name}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        zoo.RemoveEnclosure(zoo.Enclosures[choice]);

        Console.WriteLine("Enclosure removed. Press Enter to continue...");
        Console.ReadLine();
    }

    static void AssignAnimalToEnclosure()
    {
        Console.Clear();
        if (zoo.Animals.Count == 0 || zoo.Enclosures.Count == 0)
        {
            Console.WriteLine("No animals or enclosures available.");
            return;
        }

        Console.WriteLine("Select an animal:");
        for (int i = 0; i < zoo.Animals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {zoo.Animals[i].Name}");
        }

        int animalChoice = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Select an enclosure:");
        for (int i = 0; i < zoo.Enclosures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {zoo.Enclosures[i].Name}");
        }

        int enclosureChoice = int.Parse(Console.ReadLine()) - 1;
        zoo.AssignAnimalToEnclosure(zoo.Animals[animalChoice], zoo.Enclosures[enclosureChoice]);

        Console.WriteLine("Animal assigned to enclosure. Press Enter to continue...");
        Console.ReadLine();
    }

    static void RemoveAnimalFromEnclosure()
    {
        Console.Clear();
        if (zoo.Animals.Count == 0 || zoo.Enclosures.Count == 0)
        {
            Console.WriteLine("No animals or enclosures available.");
            return;
        }

        Console.WriteLine("Select an animal:");
        for (int i = 0; i < zoo.Animals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {zoo.Animals[i].Name}");
        }

        int animalChoice = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Select an enclosure:");
        for (int i = 0; i < zoo.Enclosures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {zoo.Enclosures[i].Name}");
        }

        int enclosureChoice = int.Parse(Console.ReadLine()) - 1;
        zoo.RemoveAnimalFromEnclosure(zoo.Animals[animalChoice], zoo.Enclosures[enclosureChoice]);

        Console.WriteLine("Animal removed from enclosure. Press Enter to continue...");
        Console.ReadLine();
    }

    static void HireZookeeper()
    {
        Console.Clear();
        Console.Write("Enter zookeeper name: ");
        string name = Console.ReadLine();
        Console.Write("Enter specialization: ");
        string specialization = Console.ReadLine();

        Zookeeper zookeeper = new Zookeeper { Name = name, Specialization = specialization };
        zoo.HireZookeeper(zookeeper);

        Console.WriteLine("Zookeeper hired. Press Enter to continue...");
        Console.ReadLine();
    }

    static void AssignZookeeper()
    {
        Console.Clear();
        if (zoo.Zookeepers.Count == 0 || zoo.Enclosures.Count == 0)
        {
            Console.WriteLine("No zookeepers or enclosures available.");
            return;
        }

        Console.WriteLine("Select a zookeeper:");
        for (int i = 0; i < zoo.Zookeepers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {zoo.Zookeepers[i].Name}");
        }

        int zookeeperChoice = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Select an enclosure:");
        for (int i = 0; i < zoo.Enclosures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {zoo.Enclosures[i].Name}");
        }

        int enclosureChoice = int.Parse(Console.ReadLine()) - 1;
        zoo.Zookeepers[zookeeperChoice].AssignEnclosure(zoo.Enclosures[enclosureChoice]);

        Console.WriteLine("Zookeeper assigned to enclosure. Press Enter to continue...");
        Console.ReadLine();
    } 
    static void SimulateDay()
    {
        Console.Clear();
        zoo.SimulateDay();
        Console.ReadLine();
    }

    static void RemoveAnimal()
    {
        Console.Clear();
        if (zoo.Animals.Count == 0)
        { Console.WriteLine("No animals to remove.");
            return; }

        Console.WriteLine("Select an animal to remove:");
        for (int i = 0; i < zoo.Animals.Count; i++)
        { Console.WriteLine($"{i + 1}. {zoo.Animals[i].Name}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;
        zoo.RemoveAnimal(zoo.Animals[choice]);
        Console.WriteLine("Animal removed. Press Enter to continue...");
        Console.ReadLine();
    }
    static void Main() //loop of showing menu
    {
        while (true)
        {
            ShowMenu();
            int choice = GetMenuChoice();

            switch (choice)  //menu of choise
            {
                case 1: AddAnimal(); break;
                case 2: CreateEnclosure(); break;
                case 3: RemoveEnclosure(); break;
                case 4: AssignAnimalToEnclosure(); break;
                case 5: RemoveAnimalFromEnclosure(); break;
                case 6: HireZookeeper(); break;
                case 7: AssignZookeeper(); break;
                case 8: SimulateDay(); break;
                case 9: RemoveAnimal(); break;  
                case 10: return;
                default: Console.WriteLine("Invalid option. Try again."); break;
            }
        }
    }
}
