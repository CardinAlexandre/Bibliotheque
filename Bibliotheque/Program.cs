using Bibliotheque.Models;

Biblio bibliotheque = new Biblio();

Roman roman1 = new Roman("CToutVert", "Alex", "Aventure");
BD bd1 = new BD("CToutJaune", "Thomas", 1);
Roman roman2 = new Roman("CToutRouge", "Arthur", "Policier");

bibliotheque.AjouterLivre(roman1);
bibliotheque.AjouterLivre(bd1);
bibliotheque.AjouterLivre(roman2);

Console.WriteLine("Affichage de tous les livres dans la bibliothèque :");
bibliotheque.AfficherLivres();

Console.Write("\nEntrez le nom de l'auteur pour chercher ses livres : ");
string auteurRecherche = Console.ReadLine();

List<Livre> livresTrouves = bibliotheque.ChercherLivresParAuteur(auteurRecherche);

Console.WriteLine($"\nLivres de {auteurRecherche} :");
if (livresTrouves.Count > 0)
{
    foreach (var livre in livresTrouves)
    {
        livre.AfficherDetails();
    }
}
else
{
    Console.WriteLine("Aucun livre trouvé pour cet auteur.");
}