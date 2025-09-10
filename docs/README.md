### Bibliothèque – Project Documentation

This repository contains a small C# console application that manages an in-memory library of books. It demonstrates a minimal domain model with an abstract base type (`Livre`) and concrete specializations (novel and comic), along with a `Biblio` class to add, list, and search books.

#### Features
- Add books to an in-memory collection
- List the current catalog
- Search books by author (exact match)

#### Prerequisites
- **.NET SDK 7.0+**

#### Build and Run
```bash
dotnet build
dotnet run --project Bibliotheque.csproj
```

#### Quickstart (Programmatic)
```csharp
using Bibliotheque.Models;

var bibliotheque = new Biblio();

var roman = new Roman("CToutVert", "Alex", "Aventure");
var bd = new BD("CToutJaune", "Thomas", 1);

bibliotheque.AjouterLivre(roman);
bibliotheque.AjouterLivre(bd);

// List all
bibliotheque.AfficherLivres();

// Search by author (exact, case-sensitive)
var livresAlex = bibliotheque.ChercherLivresParAuteur("Alex");
foreach (var livre in livresAlex)
{
    livre.AfficherDetails();
}
```

#### Documentation Index
- API Reference
  - [`Bibliotheque.Models` namespace](./api/README.md)
  - [`Biblio` class](./api/Biblio.md)
  - [`Livre` abstract class](./api/Livre.md)
  - [`Roman` class](./api/Roman.md)
  - [`BD` class](./api/BD.md)
- Guides
  - [Quickstart](./guides/Quickstart.md)
  - [Integration Guide](./guides/Integration.md)

Note: `Roman` and `BD` are internal to this assembly in the current source. They are available to the console app, but if you plan to expose them from a library to other assemblies, make them `public`.

