using System;
namespace Bibliotheque.Models
{
    public abstract class Livre
	{
        public string Titre { get; set; }
        public string Auteur { get; set; }

        public Livre(string titre, string auteur)
        {
            Titre = titre;
            Auteur = auteur;
        }

        public abstract void AfficherDetails();
    }

    class Roman : Livre
    {
        public string Genre { get; set; }

        public Roman(string titre, string auteur, string genre) : base(titre, auteur)
        {
            Genre = genre;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Genre: {Genre}");
        }
    }

    class BD : Livre
    {
        public int NumeroTome { get; set; }

        public BD(string titre, string auteur, int numeroTome) : base(titre, auteur)
        {
            NumeroTome = numeroTome;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Tome: {NumeroTome}");
        }
    }
}
