### `Roman` (class)

Namespace: `Bibliotheque.Models`

Represents a novel. In the current source, `Roman` is internal (no access modifier). If you plan to expose it from a library, mark it `public`.

#### Inheritance
`Roman` : `Livre`

#### Properties
- `string Genre { get; set; }` – Literary genre (e.g., "Policier", "Aventure").

#### Constructors
- `Roman(string titre, string auteur, string genre)`
  - Initializes `Titre`, `Auteur`, and `Genre`.

#### Overrides
- `override void AfficherDetails()`
  - Prints: `Titre: {Titre}, Auteur: {Auteur}, Genre: {Genre}`

#### Usage
```csharp
using Bibliotheque.Models;

var roman = new Roman("CToutRouge", "Arthur", "Policier");
roman.AfficherDetails();
```

