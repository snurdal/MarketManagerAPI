namespace MarketManagerAPI.Models
{
    public class Category : Base
    {
        public ICollection<Product> Products { get; set; } = [];
    }
}

