using LinqEtSeedEF.Models;

namespace LinqEtSeedEF.ViewModels
{
    public class DataViewModel
    {
        public List<Client>? Clients { get; set; }
        public List<Commande>? Commandes { get; set; }
        public List<CommandePlat>? CommandePlats { get; set; }
        public List<Plat>? Plats { get; set; }
        public List<Restaurant>? Restaurants { get; set; }
    }
}
