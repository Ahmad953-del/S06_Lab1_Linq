namespace LinqEtSeedEF.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public List<Commande> Commandes { get; set; }
        public List<Plat> Plats { get; set; }
    }
}
