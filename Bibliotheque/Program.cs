using Bibliotheque.Models;

Biblio bibliotheque = new Biblio();

Roman roman1 = new Roman("CToutVert", "Alex", "Aventure");
BD bd1 = new BD("CToutJaune", "Thomas", 1);
Roman roman2 = new Roman("CToutRouge", "Arthur", "Policier");
Livre book = new Livre("CToutNoir", "FDP");
bibliotheque.AjouterLivre(roman1);
bibliotheque.AjouterLivre(bd1);
bibliotheque.AjouterLivre(roman2);
bibliotheque.AjouterLivre(book);

Console.WriteLine("\nAffichage de tous les livres dans la bibliothèque :");
bibliotheque.AfficherLivres();
biblio();

void biblio()
{
    Console.WriteLine("\n1. Pour chercher un auteur \n2. Pour ajouter un livre\n3. Pour quitter\n");
    string saisirNumero = Console.ReadLine();

    if (saisirNumero == "1")
    {
        Console.WriteLine("\nEntrez le nom de l'auteur pour chercher ses livres : ");
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
            biblio();
        }

        afficher();
    }
    else if (saisirNumero == "2")
    {
        Console.WriteLine("\nEntrez le titre du livre");
        string titre = Console.ReadLine();

        Console.WriteLine("\nEntrez le nom de l'auteur");
        string auteur = Console.ReadLine();

        Console.WriteLine("\nEntrez le genre ou le numéro de tome");
        string data = Console.ReadLine();

        if (int.TryParse(data, out int parsedInt))
        {
            bibliotheque.AjouterLivre(new BD(titre, auteur, parsedInt));
        }
        else
        {
            bibliotheque.AjouterLivre(new Roman(titre, auteur, data));
        }

        afficher();
    }
    else
    {
        Console.WriteLine("\nAu revoir.");
    }
}

void afficher()
{
    Console.WriteLine("\nAfficher la liste des livres ? oui/non");
    string afficher = Console.ReadLine();

    if (afficher.ToLower() == "oui")
    {
        Console.WriteLine("\nAffichage de tous les livres dans la bibliothèque :");
        bibliotheque.AfficherLivres();
        biblio();
    }
    else
    {
        biblio();
    }
}
