using System;

class Articles
{
    public Articles(string name, string description, Authors author, DateTime datepublished)
    {
        this.name = name;
        this.description = description;
        this.author = author;
        this.datepublished = datepublished;
    }

    public string name { get; }
    public string description { get; }
    public Authors author { get; }
    public DateTime datepublished { get; }

    public void DisplayArticle()
    {
        Console.WriteLine($"Name of the Article: {name}");
        Console.WriteLine($"Description of the Article: {description}");
        author.aboutAuthor();
        Console.WriteLine($"Date Published: {datepublished:dd/MM/yyyy}");
    }
}