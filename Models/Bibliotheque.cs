using System;
namespace Bibliotheque.Models
{
	public class Biblio
	{
        private List<Livre> livres = new List<Livre>();

        public void AjouterLivre(Livre livre)
        {
            livres.Add(livre);
        }

        public void AfficherLivres()
        {
            foreach (var livre in livres)
            {
                livre.AfficherDetails();
            }
        }

        public List<Livre> ChercherLivresParAuteur(string auteur)
        {
            return livres.FindAll(livre => livre.Auteur.Equals(auteur));
        }
    }
}

