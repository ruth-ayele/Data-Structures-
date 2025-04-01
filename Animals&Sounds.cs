// Written by Ruth Ayele
// Due 02/27/2025

public class Animal
{
    // Class variable with a get and set
    private string name;
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    // Constructor
    public Animal(string name)
    {
        this.name = name;
    }

    // Virtual Method
    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }

    // Method
    public override string ToString()
    {
        return $"Animal: {this.name}, Sound: {MakeSound()}";
    }
}

// Child classes

public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override string MakeSound()
    {
        return "Bark";
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override string MakeSound()
    {
        return "Meow";
    }
}