// Written by Ruth Ayele
// Due 02/27/2025

public class Vehicle
{
    // Class Variables
    private string make;
    private string model;
    private int year;

    // Gets and Sets
    public string Make
    { 
        get { return this.make; } 
        set { this.make = value; } 
    }
    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public int Year
    {
        get { return this.year; }
        set { this.year = value; }
    }

    // Constructor
    public Vehicle(string make, string model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
    }

    // Method
    public override string ToString()
    {
        return $"{this.year} {this.make} {this.model}";
    }
}

// Child classes

public class Car : Vehicle
{
    // Class variable with a get and set
    private int numOfDoors;
    public int NumOfDoors
    {
        get { return this.numOfDoors; }
        set { this.numOfDoors = value; }
    }

    // Constructor
    public Car(string make, string model, int year, int numofDoors) : base(make, model, year)
    {
        this.numOfDoors = numOfDoors;
    }

    // Method
    public override string ToString()
    {
        return $"{base.ToString()} with {this.numOfDoors} doors";
    }
}

public class Motorcycle : Vehicle
{
    private bool hasSidecar;
    public bool HasSidecar
    {
        get { return this.hasSidecar; }
        set { this.hasSidecar = value; }
    }

    public Motorcycle(string make, string model, int year, bool hasSidecar) : base(make, model, year) 
    {
        this.hasSidecar = hasSidecar;
    }

    public override string ToString()
    {
        return $"{base.ToString()} (Has Sidecar: {this.hasSidecar})";
    }
}
