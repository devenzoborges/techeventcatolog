using System;

// 1) Create the authors first: Books, Articles and Courses need an Authors object
Authors author1 = new Authors(
    "Machado de Assis",
    "machado@email.com",
    "Brazilian writer and founder of the Brazilian Academy of Letters."
);

Authors author2 = new Authors(
    "Ana Souza",
    "ana.souza@email.com",
    "Developer and programming teacher with 10 years of experience."
);

// 2) Create a book (name, description, author, pages, genre, datepublished)
Books book = new Books(
    "Dom Casmurro",
    "A novel about Bentinho and his doubt about Capitu's betrayal.",
    author1,
    256,
    "Novel",
    new DateTime(1899, 1, 1)
);

// 3) Create an article (name, description, author, datepublished)
Articles article = new Articles(
    "Introduction to C#",
    "An article that explains the basic concepts of the C# language.",
    author2,
    new DateTime(2024, 5, 10)
);

// 4) Create a course (name, description, duration, author, level, datepublished)
Courses course = new Courses(
    "C# for Beginners",
    "A complete C# course from scratch, with hands-on exercises.",
    20,
    author2,
    "Beginner",
    new DateTime(2024, 8, 1)
);

// 5) Display everything
Console.WriteLine("===== BOOK =====");
book.DisplayBook();

Console.WriteLine();
Console.WriteLine("===== ARTICLE =====");
article.DisplayArticle();

Console.WriteLine();
Console.WriteLine("===== COURSE =====");
course.aboutCourse();