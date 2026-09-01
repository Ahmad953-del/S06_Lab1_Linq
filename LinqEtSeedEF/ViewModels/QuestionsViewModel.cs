using LinqEtSeedEF.Models;

namespace LinqEtSeedEF.ViewModels
{
    public class QuestionsViewModel
    {
        public DecimalViewModel? PrixPlatLePlusCher { get; set; }
        public DecimalViewModel? ValeurTotalDesPlats { get; set; }
        public DecimalViewModel? ValeurTotalDesCommandes { get; set; }
        public DecimalViewModel? PrixCommandeLaPlusCher { get; set; }

        public VegetarienViewModel? VegetarienResto1 { get; set; }
        public VegetarienViewModel? VegetarienResto2 { get; set; }
        public VegetarienViewModel? VegetarienResto3 { get; set; }

        public PlatsViewModel? PlatsVege { get; set; }
        public PlatsViewModel? PlatsLesPlusChers { get; set; }
    }
}
