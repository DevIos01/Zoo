namespace Zoo;

class Parrot : Animal
{
    // New property that only parrots have (in centimeters)
    public int WingSpan { get; set; } = 50;

    // Constructor, sends default values for a parrot to the Animal constructor
    public Parrot(string name) : base(name, 10, 0.4, 2, false)
    {
    }

    // Parrots squawk and can say a word
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} säger: Kraa! Hej hej!");
    }

    // New method that only parrots have
    public void Fly()
    {
        Console.WriteLine($"{Name} flyger iväg.");
    }
}
