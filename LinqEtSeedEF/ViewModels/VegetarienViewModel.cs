namespace LinqEtSeedEF.ViewModels
{
    public class VegetarienViewModel
    {
        public VegetarienViewModel(string title,
            bool? toutVege, bool? toutVegeLinq,
            bool? optionVege, bool? optionVegeLinq)
        {
            Title = title;
            
            ToutVege = toutVege;
            ToutVegeLinq = toutVegeLinq;
            ToutVegeMemeValeur = toutVege.HasValue && toutVege == toutVegeLinq;

            OptionVege = optionVege;
            OptionVegeLinq = optionVegeLinq;
            OptionVegeMemeValeur = optionVege.HasValue && optionVege == optionVegeLinq;
        }

        public string Title { get; set; }

        public bool? ToutVege { get; set; }
        public bool? ToutVegeLinq { get; set; }
        public bool ToutVegeMemeValeur { get; set; }
        
        public bool? OptionVege { get; set; }
        public bool? OptionVegeLinq { get; set; }
        public bool OptionVegeMemeValeur { get; set; }
    }
}
