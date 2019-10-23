using System;

namespace OnionArchitectureSample.Domain
{
    public class Product
    {
        public Product(string name, float price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            PrivateCode = "PrivateCode";
        }

        public Guid Id { get; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string PrivateCode { get; }
    }
}
