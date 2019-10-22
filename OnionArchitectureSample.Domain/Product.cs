using System;

namespace OnionArchitectureSample.Domain
{
    public class Product
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
