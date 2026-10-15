using System;

class Courses
{
    public Courses(string name, string description, int duration, Authors author, string level, DateTime datepublished)
    {
        this.name = name;
        this.description = description;
        this.duration = duration;
        this.author = author;
        this.level = level;
        this.datepublished = datepublished;
    }

    public string name { get; }
    public string description { get; }
    public int duration { get; }
    public Authors author { get; }
    public string level { get; }
    public DateTime datepublished { get; }

    public void aboutCourse()
    {
        Console.WriteLine($"Name of the Course: {name}");
        Console.WriteLine($"Description of the Course: {description}");
        author.aboutAuthor();
        Console.WriteLine($"Duration of the Course: {duration} hours");
        Console.WriteLine($"Level of the Course: {level}");
        Console.WriteLine($"Date Published: {datepublished:dd/MM/yyyy}");
    }
}