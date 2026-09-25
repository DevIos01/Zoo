namespace Zoo;

class Dog : Animal
{
    // New property that only dogs have
    public string Breed { get; set; } = "Blandras";

    // Constructor, sends default values for a dog to the Animal constructor
    public Dog(string name) : base(name, 3, 25.0, 4, true)
    {
    }

    // Dogs bark instead of the default sound
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} säger: Voff voff!");
    }

    // New method that only dogs have
    public void Fetch()
    {
        Console.WriteLine($"{Name} hämtar pinnen.");
    }
}
