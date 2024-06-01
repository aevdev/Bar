namespace Bar.Models
{
    public class Cocktail
    {
        public string id { get; set; } //Нужно также в выдаче на API сервере добавить id
        public string name { get; set; }
        public string sub_name { get; set; }
        public string picture_link { get; set; }
        public double strength { get; set; }
        public double bitterness { get; set; }
        public double saltiness { get; set; }
        public double sourness { get; set; }
        public double spiciness { get; set; }
        public double sweetness { get; set; }
        public int year { get; set; }
        public string source { get; set; }
        public string recipe { get; set; }
        public string garnish { get; set; }
        public string history { get; set; }
        public double rating { get; set; }



    }
}
