using LinqEtSeedEF.Models;

namespace LinqEtSeedEF.ViewModels
{
    public class PlatsViewModel
    {
        public PlatsViewModel(string title, List<Plat> plats, List<Plat> platsLinq)
        {
            Title = title;

            Plats = plats;
            PlatsLinq = platsLinq;

            // Si une liste est vides ou si les listes n'ont pas le même nombre d'éléments
            // On va afficher un crochet rouge
            if (plats.Count == 0 || plats.Count != platsLinq.Count)
            {
                MemeValeur = false;
            }
            else
            {
                // Vérifier si les listes ont les mêmes Ids
                MemeValeur = ListesAvecMemeIds();
            }
        }

        private bool ListesAvecMemeIds()
        {
            for (int i = 0; i < Plats.Count; i++)
            {
                if (Plats[i].Id != PlatsLinq[i].Id)
                    return false;
            }
            return true;
        }

        public string Title { get; set; }

        public List<Plat> Plats { get; set; }
        public List<Plat> PlatsLinq { get; set; }
        public bool MemeValeur { get; set; }
    }
}
