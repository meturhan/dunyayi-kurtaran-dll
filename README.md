# Dünyayı Kurtaran DLL — The World-Saving Class Library

**A humorous C# Class Library that saves the world — but only if you ask the right Turkish action hero.**

![Language](https://img.shields.io/badge/language-C%23-blue)
![Platform](https://img.shields.io/badge/platform-.NET%20Library-purple)
![IDE](https://img.shields.io/badge/IDE-Visual%20Studio%202008-9cf)

---

## Overview

> *"Dünyayı Kurtaran Adam"* (The Man Who Saves the World) is a legendary 1982 Turkish cult film starring **Cüneyt Arkın** — a low-budget sci-fi adventure famous for its unintentional comedy, recycled Star Wars footage, and enduring place in Turkish pop culture.

This DLL is a **parody homage** to that film. Pass in `"Cuneyt Arkin"` (note: the code uses the Anglicized spelling without the Turkish diacritics) and the DLL declares the world saved. Pass anything else, and you get scolded in Turkish slang: *"Bırak Uleyn kızı..!"*

---

## Features

- **🌍 World-saving function** — call `DunyayiKurtar()` with the right name
- **🎭 Turkish pop culture reference** — direct homage to Cüneyt Arkın
- **📦 Simple class library structure** — demonstrates DLL project setup
- **🔧 Easy to integrate** — add as a reference to any .NET application

---

## How It Works

### The API

```csharp
namespace DunyayiKurtaranDLL
{
    public class DLL
    {
        public void DunyayiKurtar(string KimKurtarsin)
        {
            if (KimKurtarsin == "Cuneyt Arkin")
            {
                Console.WriteLine("Dunya Kurtarildi..!");
            }
            else
            {
                Console.WriteLine("Birak Uleyn kizi..!");
            }
        }
    }
}
```

### Usage

```csharp
using DunyayiKurtaranDLL;

DLL kurtaricim = new DLL();
kurtaricim.DunyayiKurtar("Cuneyt Arkin");
// Output: "Dunya Kurtarildi..!"

kurtaricim.DunyayiKurtar("Superman");
// Output: "Birak Uleyn kizi..!"
```

### Parameters

| Parameter        | Type     | Description                          |
|------------------|----------|--------------------------------------|
| `KimKurtarsin`   | `string` | Who should save the world? (Hint: Cüneyt Arkın) |

---

## The Cultural Reference

**Cüneyt Arkın** (1937–2022) was a Turkish actor, director, producer, and martial artist. He starred in hundreds of films across multiple genres. *"Dünyayı Kurtaran Adam"* (1982) is perhaps his most internationally famous work — a bizarre sci-fi film that:

- Used unauthorized footage from Star Wars
- Featured Arkın fighting aliens and robots with swords
- Became a cult classic celebrated for its sheer audacity
- Was parodied in popular culture, including a sequel in 2023

The DLL's scolding response *"Bırak Uleyn kızı..!"* is a Turkish slang phrase (~"Leave it, girl...") that fits the film's campy, over-the-top dialogue style.

---

## Project Structure

```
DunyayiKurtaranDLL/
├── Class1.cs                  # The world-saving logic (21 lines)
├── DunyayiKurtaranDLL.csproj  # Class library project file
└── Properties/                # Assembly info
DunyayiKurtaranDLL.sln         # Visual Studio solution file
```

---

## Building & Using

1. **Prerequisites**: .NET Framework 2.0+, Visual Studio 2008+
2. Open `DunyayiKurtaranDLL.sln` in Visual Studio
3. Build the project to produce `DunyayiKurtaranDLL.dll`
4. Add the DLL as a reference in any .NET project
5. Call `DLL.DunyayiKurtar()` with the appropriate name

### Example Integration

```csharp
// Console app using the DLL
using DunyayiKurtaranDLL;

class Program
{
    static void Main()
    {
        Console.Write("Who will save the world? ");
        string name = Console.ReadLine();
        
        DLL hero = new DLL();
        hero.DunyayiKurtar(name);
    }
}
```

---

## Concepts Demonstrated

| Concept | Implementation |
|---------|---------------|
| **Class Library** | .NET DLL project producing a reusable assembly |
| **Namespaces** | Organization of types in `DunyayiKurtaranDLL` namespace |
| **String Comparison** | Case-sensitive `==` operator for parameter matching |
| **Console Output** | `Console.WriteLine()` for results |
| **Project References** | How to structure a library for consumption by other projects |

---

## Fun Facts

- ✅ This DLL is 100% guaranteed to save the world — if you specify the correct name
- ❌ Will not save the world if you specify any other name (including Cüneyt Arkın with correct Turkish characters — the code checks for the unaccented "Cuneyt Arkin")
- 🎬 The 1982 film was made on a shoestring budget and remains a beloved cult classic in Turkey
- 📦 Despite its small size (21 lines of code), this might be the most important DLL ever written

---

## License

Academic project — provided as-is for entertainment and educational purposes.

*May Cüneyt Arkın save us all.*
