namespace Zoo;

class Cat : Animal
{
    // New property that only cats have
    public string FurColor { get; set; } = "Grå";

    // Constructor, sends default values for a cat to the Animal constructor
    public Cat(string name) : base(name, 5, 4.5, 4, true)
    {
    }

    // Cats meow instead of the default sound
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} säger: Mjau!");
    }

    // New method that only cats have
    public void Purr()
    {
        Console.WriteLine($"{Name} spinner nöjt.");
    }
}
