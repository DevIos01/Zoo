namespace Zoo;

class Program
{
    static void Main(string[] args)
    {
        // Create a basic animal and test the shared methods
        Animal animal = new Animal("Okänt djur", 2, 12.5, 4, false);
        animal.MakeSound();
        animal.Eat();
        animal.Sleep();
    }
}
