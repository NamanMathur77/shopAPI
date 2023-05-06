namespace ShopServer.Models.DTO
{
    public class ProductDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public DateTime create_at { get; set; }
        public DateTime modified_at { get; set; }
    }
}
