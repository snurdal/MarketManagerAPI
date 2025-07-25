﻿namespace MarketManagerAPI.Models
{
    public abstract class Base
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;
        public bool Deleted { get; set; } = false;
    }

    public class Cart
    {
        public int Id { get; set; }
        public string Status { get; set; } = "Pending";
        public ICollection<CartItem> Items { get; set; } = [];
    }

    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; } = 1;
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int CartId { get; set; }
        public Cart? Cart { get; set; }
    }

    public class Receipt
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public ICollection<ReceiptItem> Items { get; set; } = [];
    }

    public class ReceiptItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int ReceiptId { get; set; }
        public Receipt? Receipt { get; set; }
    }
}

