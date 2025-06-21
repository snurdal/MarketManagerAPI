namespace MarketManagerAPI.Models
{
    public class Product : Base
    {
        public required string Description { get; set; }
        public decimal Price { get; set; }

        public int Stock { get; set; } = 0;

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public int BrandId { get; set; }
        public Brand? Brand { get; set; }
    }
}

