using System;

// 1. Single Inheritance
/*class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal  // Single inheritance
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// ------------------------
// 2. Multilevel Inheritance
// ------------------------
class BabyDog : Dog  // Multilevel inheritance
{
    public void Weep()
    {
        Console.WriteLine("Baby dog is weeping.");
    }
}

// ------------------------
// 3. Hierarchical Inheritance
// ------------------------
class Cat : Animal  // Another child of Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }
}

// ------------------------
// Main Program
// ------------------------
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Single Inheritance ===");
        Dog d = new Dog();
        d.Eat();  // Inherited from Animal
        d.Bark();

        Console.WriteLine("\n=== Multilevel Inheritance ===");
        BabyDog bd = new BabyDog();
        bd.Eat();   // From Animal
        bd.Bark();  // From Dog
        bd.Weep();  // From BabyDog

        Console.WriteLine("\n=== Hierarchical Inheritance ===");
        Cat c = new Cat();
        c.Eat();   // From Animal
        c.Meow();  // From Cat

        Console.ReadLine();
    }
}
*/
