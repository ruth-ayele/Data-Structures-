// Written by Ruth Ayele
// Due 02/27/2025

public class Employee
{
    // Class variables
    private string name;
    private double salary;

    // Gets and Sets
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Salary
    {
        get { return salary; }
        set { this.salary = value; }
    }

    // Constructor 
    public Employee(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }

    // Method 
    public override string ToString()
    {
        return $"Employee: {this.name}, Salary: {this.salary}";
    }
}

// Child classes

public class Manager : Employee
{
    // Class variable with a get and set
    private int numOfManaged;
    public int NumOfManaged
    {
        get { return this.numOfManaged; }
        set { this.numOfManaged = value; }
    }

    public Manager(string name, double salary, int numOfManaged) : base(name, salary)
    {
        this.numOfManaged = numOfManaged;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Manages {this.numOfManaged} employees";
    }
}

public class Engineer : Employee
{
    private string specialization;
    public string Specialization
    {
        get { return this.specialization; }
        set { this.specialization = value; }
    }

    public Engineer(string name, double salary, string specialization) : base(name, salary)
    {
        this.specialization = specialization;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Specialization: {this.specialization}";
    }
}
