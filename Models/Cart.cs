﻿namespace WomanShop.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public List<CartItem> Items{ get; set; }

        public Cart( int userId,Product product )
        {
            Id = new Guid();
            UserId = userId;
            Items = new List<CartItem>() {new CartItem(product) };
        }

        public decimal Amount
        {
            get 
            {
                return Items.Sum(cartItem=>cartItem.Amount);
            }
        }
    }
}