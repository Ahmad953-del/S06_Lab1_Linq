namespace LinqEtSeedEF.Models
{
    public class Plat
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public int RestaurantId { get; set; }
        public bool Vegetarien {  get; set; }
        public Restaurant Restaurant { get; set; }
        public List<CommandePlat> CommandesPlats { get; set; }
    }
}
