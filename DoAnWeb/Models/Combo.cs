
namespace DoAnWeb.Models
{
    public class Combo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Discounted_price { get; set; }

        public DateTime Create_at { get; set; }

        public DateTime expired_at { get; set;}


        public double price_old { get; set; }  
        
        public double price_new { get; set;}
    }
}
