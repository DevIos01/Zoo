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

        Console.WriteLine();

        // Create a cat, it gets its default values from the Cat class
        Cat cat = new Cat("Misse");
        Console.WriteLine($"{cat.Name}: pälsfärg {cat.FurColor}, {cat.Age} år, {cat.Weight} kg");
        cat.MakeSound();
        cat.Sleep();
        cat.Purr();

        Console.WriteLine();

        // Create a parrot, it gets its default values from the Parrot class
        Parrot parrot = new Parrot("Polly");
        Console.WriteLine($"{parrot.Name}: vingbredd {parrot.WingSpan} cm, {parrot.Age} år, {parrot.Weight} kg");
        parrot.MakeSound();
        parrot.Eat();
        parrot.Fly();
    }
}
