<div align="center">

```
 ████████╗███████╗ ██████╗██╗  ██╗
 ╚══██╔══╝██╔════╝██╔════╝██║  ██║
    ██║   █████╗  ██║     ███████║
    ██║   ██╔══╝  ██║     ██╔══██║
    ██║   ███████╗╚██████╗██║  ██║
    ╚═╝   ╚══════╝ ╚═════╝╚═╝  ╚═╝
  ░▒▓█ C A T A L O G // v1.0 █▓▒░
```

# `[ T E C H C A T A L O G ]`

### `>> JACK INTO THE KNOWLEDGE GRID <<`

![C#](https://img.shields.io/badge/C%23-FF00E5?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-00F0FF?style=for-the-badge&logo=dotnet&logoColor=black)
![VS Code](https://img.shields.io/badge/VS%20CODE-FCEE0A?style=for-the-badge&logo=visualstudiocode&logoColor=black)
![Windows](https://img.shields.io/badge/WINDOWS-FF2A6D?style=for-the-badge&logo=windows&logoColor=white)
![Status](https://img.shields.io/badge/NET__LINK-ONLINE-39FF14?style=for-the-badge)

`▓▒░ NEON ░▒▓ GRID ░▒▓ ONLINE ░▒▓`

</div>

---

## `> BOOT_SEQUENCE.exe`

```
[ OK ] Loading core modules.......... done
[ OK ] Linking authors database...... done
[ OK ] Compiling C# runtime.......... done
[ OK ] Connecting books, articles, courses
[WARN] Corporate firewall not detected. Proceed.
```

**TechCatalog** is a C# console application built to practice **Object-Oriented Programming**. It models a catalog of educational content where every item is wired to its creator through **object composition**.

> Every book, article and course carries an `Authors` object. Pull one record and the author's data comes with it. No data left behind.

---

## `> SYSTEM_MODULES`

| 🔌 | MODULE | DATA PAYLOAD |
|:--:|:------:|:-------------|
| 👤 | `Authors` | name, email, bio |
| 📘 | `Books` | name, description, author, pages, genre, date published |
| 📰 | `Articles` | name, description, author, date published |
| 🎓 | `Courses` | name, description, duration (hours), author, level, date published |

```
                 ╔═══════════╗
                 ║  AUTHORS  ║
                 ╚═════╤═════╝
            ┌──────────┼──────────┐
            ▼          ▼          ▼
        ┌───────┐ ┌──────────┐ ┌─────────┐
        │ BOOKS │ │ ARTICLES │ │ COURSES │
        └───────┘ └──────────┘ └─────────┘
```

---

## `> CYBERDECK_LOADOUT`

| 🧰 TOOL | ⚙️ FUNCTION |
|:--------|:------------|
| **C#** | Core language. The code that runs the grid |
| **.NET SDK** | Build and runtime platform |
| **Visual Studio Code** | Main hacking terminal (code editor) |
| **C# Dev Kit** | IntelliSense, debugging and project support |
| **dotnet CLI** | Compile and run straight from the command line |
| **PowerShell / Windows Terminal** | Command line interface |

---

## `> FILE_SYSTEM`

```
Wheel/
├── Program.cs          // entry point: spawns objects, prints data
├── authors.cs          // Authors class
├── books.cs            // Books class
├── articles.cs         // Articles class
├── courses.cs          // Courses class
└── TechCatalog.csproj  // project config
```

---

## `> INITIATE_LAUNCH`

```bash
# 1. open the project folder in VS Code
#    File -> Open Folder -> Wheel

# 2. jack in
cd Wheel
dotnet run
```

> ⚠️ **WARNING:** every `.cs` file must live in the **same folder** as the `.csproj`. Otherwise the compiler can't see the classes and the system will throw `CS0246`.

---

## `> OUTPUT_STREAM`

```
===== BOOK =====
Name of the Book: Dom Casmurro
Description of the Book: A novel about Bentinho and his doubt about Capitu's betrayal.
Author: Machado de Assis
Email of Machado de Assis: machado@email.com
Meet Machado de Assis: Brazilian writer and founder of the Brazilian Academy of Letters.
Number of Pages: 256
Genre of the Book: Novel
Date Published: 01/01/1899
```

---

## `> SKILLS_UNLOCKED`

- [x] Classes and objects
- [x] Constructors
- [x] Auto-implemented properties (`{ get; }` / `{ get; set; }`)
- [x] Object composition
- [x] Display methods
- [x] Top-level statements in `Program.cs`

---

## `> FUTURE_UPGRADES`

- [ ] Interactive menu to add items from the keyboard
- [ ] Store items in lists (`List<Books>`, `List<Courses>`...)
- [ ] Search by author or genre
- [ ] Save and load data from a file

---

<div align="center">

```
░▒▓█ SESSION ACTIVE █▓▒░
> keep coding. stay neon._
```

Built with 💜 C# and 💛 Visual Studio Code

</div>
