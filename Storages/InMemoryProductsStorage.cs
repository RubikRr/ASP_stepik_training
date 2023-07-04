﻿using System.Text;
using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryProductsStorage : IProductsStorage
    {

        public List<Product> Products { get; init; }
        public InMemoryProductsStorage()
        {
            Products = new List<Product>()
            {
                new Product("Пиджак",2500,"Женский пиджак","/images/products/image1.png"),
                new Product("Кеды",5000,"Кеды на лето","/images/products/image2.png"),
                new Product("Блузка",3000,"Блузка для офиса","/images/products/image3.png"),
                new Product("Платье",5000,"Платье на вечер","/images/products/image4.png"),
                new Product("Сапоги",5000,"Сапоги на лето","/images/products/image5.jpg"),
                new Product("Майка",5000,"Майка с Пухлей", "/images/products/image6.jpg"),
                new Product("Платье",4000,"Женское платье","/images/products/image7.jpg"),
                new Product("Кеды",5000,"Кеды на лето","/images/products/image1.png")
            };
        }

        public List<Product> GetAll() => Products;

        public Product TryGetById(int id) => Products.FirstOrDefault(pr => pr.Id == id);
    }
}