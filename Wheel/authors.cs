using System;

class Authors
{
    public Authors(string name, string email, string bio)
    {
        this.name = name;
        this.email = email;
        this.bio = bio;
    }

    public string name { get; }
    public string email { get; set; }
    public string bio { get; }

    public void aboutAuthor()
    {
        Console.WriteLine($"Author: {name}");
        Console.WriteLine($"Email of {name}: {email}");
        Console.WriteLine($"Meet {name}: {bio}");
    }
}