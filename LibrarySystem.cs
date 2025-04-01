// Written by Ruth Ayele
// Due 02/27/2025

public class Book
{
    // Class variables
    private string title;
    private string author;
    private int yearPublished'

    // Gets and Sets
    public string Title
    {
        get { return this.title; }
        set { this.title = value; }
    }

    public string Author
    {
        get { return this.author; }
        set { this.author = value; }
    }

    public int YearPublished
    {
        get { return this.yearPublished; }
        set { this.yearPublished = value; }
    }

    // Constructor
    public Book(string title, string author, int yearPublished)
    {
        this.title = title;
        this.author = author;
        this.yearPublished = yearPublished;
    }

    // Method 
    public override string ToString()
    {
        return $"{this.title} by {this.author} ({this.yearPublished})";
    }
}

// Child classes

public class EBook : Book
{
    private double fileSizeMB;
    public double FileSizeMB
    {
        get { return this.fileSizeMB; }
        set { this.fileSizeMB = value; }
    }

    public EBook(string title, string author, int yearPublished, double fileSizeMB) : base(title, author, yearPublished)
    {
        this.fileSizeMB = fileSizeMB;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, File Size: {this.fileSizeMB}MB";
    }
}

public class PrintedBook : Book
{
    private int pageCount;
    public int PageCount
    {
        get { return this.pageCount; }
        set { this.pageCount = value; }
    }

    public PrintedBook(string title, string author, int yearPublished, int pageCount) : base(title, author, yearPublished)
    {
        this.pageCount = pageCount;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Pages: {this.pageCount}";
    }
}