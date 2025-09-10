### `Biblio` (class)

Namespace: `Bibliotheque.Models`

Manages an in-memory list of books (`Livre`). Supports adding, listing, and searching by author.

#### Members

- `void AjouterLivre(Livre livre)`
  - Adds a book to the catalog.
  - Parameters:
    - `livre`: Instance of a subtype of `Livre` to add.

- `void AfficherLivres()`
  - Iterates through all stored books and writes their details to the console by invoking `Livre.AfficherDetails()`.

- `List<Livre> ChercherLivresParAuteur(string auteur)`
  - Returns all books whose `Auteur` equals the provided `auteur` (exact, case-sensitive match).
  - Parameters:
    - `auteur`: Author name to match exactly.

#### Usage
```csharp
using Bibliotheque.Models;

var bibliotheque = new Biblio();
bibliotheque.AjouterLivre(new Roman("CToutVert", "Alex", "Aventure"));
bibliotheque.AjouterLivre(new BD("CToutJaune", "Thomas", 1));

var alexBooks = bibliotheque.ChercherLivresParAuteur("Alex");
Console.WriteLine($"Livres de Alex: {alexBooks.Count}");

// Print all
bibliotheque.AfficherLivres();
```

#### Notes
- Search uses `string.Equals` without a comparer; it is case-sensitive and culture-invariant by default.
- Consider normalizing or using `StringComparison` if you need case-insensitive search.

