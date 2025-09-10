### Integration Guide

This project is a console application. If you want to consume the domain model (`Biblio`, `Livre`, `Roman`, `BD`) from another project, choose one of the following options.

#### Option A: Create a class library for the models
1. Create a new class library in the solution:
   ```bash
   dotnet new classlib -n Bibliotheque.Models.Library
   ```
2. Move the files under `Models/` into the new project and set access modifiers to `public` where needed:
   - Make `Roman` and `BD` `public`
3. Reference the library from your console/app project:
   ```bash
   dotnet add <YourAppProject>.csproj reference Bibliotheque.Models.Library/Bibliotheque.Models.Library.csproj
   ```
4. Use the types from the new library:
   ```csharp
   using Bibliotheque.Models;
   var biblio = new Biblio();
   biblio.AjouterLivre(new Roman("Titre", "Auteur", "Genre"));
   ```

#### Option B: Package as a NuGet for reuse
1. Convert the models project to a packable library (set `TargetFramework` and `GeneratePackageOnBuild`):
   ```xml
   <PropertyGroup>
     <TargetFramework>net7.0</TargetFramework>
     <GeneratePackageOnBuild>true</GeneratePackageOnBuild>
     <Authors>Your Name</Authors>
     <PackageId>Bibliotheque.Models</PackageId>
     <Version>1.0.0</Version>
   </PropertyGroup>
   ```
2. Build the package:
   ```bash
   dotnet pack -c Release
   ```
3. Add the package to your consumer project:
   ```bash
   dotnet add package Bibliotheque.Models --source <your-nuget-source>
   ```

#### Notes
- The current repository defines `Roman` and `BD` as internal. Mark them `public` for external reuse.
- `ChercherLivresParAuteur` is an exact, case-sensitive match. Consider adding an overload with `StringComparison`.

