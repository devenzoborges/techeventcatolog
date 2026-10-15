using System;

class Books
{
    public Books(string name, string description, Authors author, int pages, string genre, DateTime datepublished)
    {
        this.name = name;
        this.description = description;
        this.author = author;
        this.pages = pages;
        this.genre = genre;
        this.datepublished = datepublished;
    }

    public string name { get; }
    public string description { get; }
    public Authors author { get; }
    public int pages { get; }
    public string genre { get; }
    public DateTime datepublished { get; }

    public void DisplayBook()
    {
        Console.WriteLine($"Name of the Book: {name}");
        Console.WriteLine($"Description of the Book: {description}");
        author.aboutAuthor();
        Console.WriteLine($"Number of Pages: {pages}");
        Console.WriteLine($"Genre of the Book: {genre}");
        Console.WriteLine($"Date Published: {datepublished:dd/MM/yyyy}");
    }
}