### Quickstart

This guide shows how to run the console app and how to use the core types programmatically.

#### Run the Console App
```bash
dotnet run --project Bibliotheque.csproj
```

The app seeds three books and presents a simple menu:
- Enter `1` to search by author (exact match)
- Enter `2` to add a new book (enter either a genre for a novel or an integer for a comic volume)
- Any other input exits

#### Programmatic Usage
```csharp
using Bibliotheque.Models;

var bibliotheque = new Biblio();

// Add books
bibliotheque.AjouterLivre(new Roman("CToutVert", "Alex", "Aventure"));
bibliotheque.AjouterLivre(new BD("CToutJaune", "Thomas", 1));

// List all books
bibliotheque.AfficherLivres();

// Search by author
var livresDeAlex = bibliotheque.ChercherLivresParAuteur("Alex");
foreach (var livre in livresDeAlex)
{
    livre.AfficherDetails();
}
```

#### Notes & Recommendations
- Matching on author is case-sensitive. Consider changing to `StringComparison.OrdinalIgnoreCase` if needed.
- `Roman` and `BD` are internal in this project; switch them to `public` to consume from other assemblies.

