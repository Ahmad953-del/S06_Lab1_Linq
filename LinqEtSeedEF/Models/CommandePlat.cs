using Microsoft.EntityFrameworkCore;

namespace LinqEtSeedEF.Models
{
    [PrimaryKey(nameof(PlatId), nameof(CommandeId))]
    public class CommandePlat
    {
        public int PlatId { get; set; }
        public Plat Plat { get; set; }
        public int CommandeId { get; set; }
        public Commande Commande { get; set; }

        public int Quantite { get; set; }
    }
}
