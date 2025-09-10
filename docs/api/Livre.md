### `Livre` (abstract class)

Namespace: `Bibliotheque.Models`

Base class for all books.

#### Properties
- `string Titre { get; set; }` – Book title
- `string Auteur { get; set; }` – Author name

#### Constructors
- `Livre(string titre, string auteur)`
  - Initializes `Titre` and `Auteur`.

#### Methods
- `abstract void AfficherDetails()`
  - When implemented, writes a formatted description of the book to the console.

#### Usage
`Livre` is abstract; instantiate a derived type such as `Roman` or `BD`.

```csharp
using Bibliotheque.Models;

Livre livre = new Roman("CToutVert", "Alex", "Aventure");
livre.AfficherDetails();
```

