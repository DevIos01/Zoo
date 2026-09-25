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

        Console.WriteLine();

        // Create a dog, it gets its default values from the Dog class
        Dog dog = new Dog("Rex");
        Console.WriteLine($"{dog.Name}: ras {dog.Breed}, {dog.Age} år, {dog.Weight} kg");
        dog.MakeSound();
        dog.Eat();
        dog.Fetch();
    }
}
