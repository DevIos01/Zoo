namespace Zoo;

class Animal
{
    // Properties that all animals share, with default values
    public string Name { get; set; } = "Okänt djur";
    public int Age { get; set; } = 1;
    public double Weight { get; set; } = 10.0;
    public int NumberOfLegs { get; set; } = 4;
    public bool IsCarnivore { get; set; } = false;

    // Constructor used to create a new animal
    public Animal(string name, int age, double weight, int numberOfLegs, bool isCarnivore)
    {
        Name = name;
        Age = age;
        Weight = weight;
        NumberOfLegs = numberOfLegs;
        IsCarnivore = isCarnivore;
    }

    // Prints the sound of the animal, animals that inherit can override it
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} gör ett ljud.");
    }

    // Prints what the animal eats
    public void Eat()
    {
        if (IsCarnivore)
        {
            Console.WriteLine($"{Name} äter kött.");
        }
        else
        {
            Console.WriteLine($"{Name} äter växter.");
        }
    }

    // Prints that the animal is sleeping
    public void Sleep()
    {
        Console.WriteLine($"{Name} sover.");
    }
}
