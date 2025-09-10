### `BD` (class)

Namespace: `Bibliotheque.Models`

Represents a comic book (bande dessinée) with a volume number. In the current source, `BD` is internal (no access modifier). If you plan to expose it from a library, mark it `public`.

#### Inheritance
`BD` : `Livre`

#### Properties
- `int NumeroTome { get; set; }` – Volume number.

#### Constructors
- `BD(string titre, string auteur, int numeroTome)`
  - Initializes `Titre`, `Auteur`, and `NumeroTome`.

#### Overrides
- `override void AfficherDetails()`
  - Prints: `Titre: {Titre}, Auteur: {Auteur}, Tome: {NumeroTome}`

#### Usage
```csharp
using Bibliotheque.Models;

var bd = new BD("CToutJaune", "Thomas", 1);
bd.AfficherDetails();
```

