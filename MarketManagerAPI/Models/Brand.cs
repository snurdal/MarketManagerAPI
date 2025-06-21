namespace MarketManagerAPI.Models
{
    public class Brand : Base
    {
        public ICollection<Product> Products { get; set; } = [];
    }
}

