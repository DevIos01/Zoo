namespace Zoo;

class Bulldog : Dog
{
    // New property that only bulldogs have (from 1 to 10)
    public int SnoreLevel { get; set; } = 8;

    // Constructor, uses the Dog constructor and then changes the values that are different for a bulldog
    public Bulldog(string name) : base(name)
    {
        Breed = "Bulldog";
        Age = 4;
        Weight = 23.0;
    }

    // Bulldogs have a deeper bark than other dogs
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} säger: Grrr... Voff!");
    }

    // New method that only bulldogs have
    public void Snore()
    {
        Console.WriteLine($"{Name} snarkar på nivå {SnoreLevel} av 10.");
    }
}
