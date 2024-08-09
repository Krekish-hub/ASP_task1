namespace WebAppProduct.Models.DB
{
    public class DataBaseClass
    {
        public class Category
        {
            public int CategoryId { get; set; }
            public string Name { get; set; }

            public ICollection<Product> Products { get; set; }
        }

        public class Product
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }

            public int CategoryId { get; set; }
            public Category Category { get; set; }
        }
    }
}
