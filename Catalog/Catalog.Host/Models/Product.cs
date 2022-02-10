namespace Catalog.Host.Models
{
    public class Product
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public float Price { get; set; }
    }
}
