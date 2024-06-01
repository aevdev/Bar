namespace Bar.Models
{
    public class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime add_date { get; set; }
        public double pref_bitterness { get; set; }
        public double pref_saltiness { get; set; }
        public double pref_sourness { get; set; }
        public double pref_spiciness { get; set; }
        public double pref_strength { get; set; }
        public double pref_sweentess { get; set; }

        public Cocktail[]? favorite {  get; set; }
    }
}
