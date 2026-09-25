namespace Zoo;

class Chihuahua : Dog
{
    // New property that only chihuahuas have
    public string CollarColor { get; set; } = "Rosa";

    // Constructor, uses the Dog constructor and then changes the values that are different for a chihuahua
    public Chihuahua(string name) : base(name)
    {
        Breed = "Chihuahua";
        Age = 2;
        Weight = 2.5;
    }

    // Chihuahuas have a small, high bark
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} säger: Yip yip!");
    }

    // New method that only chihuahuas have
    public void Shiver()
    {
        Console.WriteLine($"{Name} darrar av kyla.");
    }
}
