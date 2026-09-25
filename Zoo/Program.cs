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

        Console.WriteLine();

        // Create a bulldog, it inherits from Dog which inherits from Animal
        Bulldog bulldog = new Bulldog("Bruno");
        Console.WriteLine($"{bulldog.Name}: ras {bulldog.Breed}, {bulldog.Age} år, {bulldog.Weight} kg");
        bulldog.MakeSound();
        bulldog.Fetch();
        bulldog.Snore();

        Console.WriteLine();

        // Create a chihuahua, it also inherits from Dog
        Chihuahua chihuahua = new Chihuahua("Pixie");
        Console.WriteLine($"{chihuahua.Name}: ras {chihuahua.Breed}, {chihuahua.Age} år, {chihuahua.Weight} kg, halsband {chihuahua.CollarColor}");
        chihuahua.MakeSound();
        chihuahua.Eat();
        chihuahua.Shiver();

        Console.WriteLine();

        // Put all animals in one array, the array only knows them as Animal
        Animal[] animals = { animal, dog, cat, parrot, bulldog, chihuahua };

        // Every animal still uses its own MakeSound because of override
        Console.WriteLine("Alla djur i zoot låter:");
        foreach (Animal zooAnimal in animals)
        {
            zooAnimal.MakeSound();
        }
    }
}
