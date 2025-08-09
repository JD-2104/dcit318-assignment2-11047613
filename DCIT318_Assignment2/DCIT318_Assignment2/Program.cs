class Program
{
    static void Main(string[] args)
    {
        Animal genericAnimal = new Animal();
        genericAnimal.MakeSound();

        Dog dog = new Dog();
        dog.MakeSound();

        Cat cat = new Cat();
        cat.MakeSound();
    }
}
