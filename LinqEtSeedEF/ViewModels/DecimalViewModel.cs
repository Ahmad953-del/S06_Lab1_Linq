namespace LinqEtSeedEF.ViewModels
{
    public class DecimalViewModel
    {
        public DecimalViewModel(string titre, decimal valeur, decimal valeurLinq)
        {
            Titre = titre;
            Valeur = valeur;
            ValeurLinq = valeurLinq;
            MemeValeur = valeur != 0 && valeurLinq == valeur;
        }

        public string Titre { get; set; }
        public decimal Valeur { get; set; }
        public decimal ValeurLinq { get; set; }
        public bool MemeValeur { get; set; }
    }
}
