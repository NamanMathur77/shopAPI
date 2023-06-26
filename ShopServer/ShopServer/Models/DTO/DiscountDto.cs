namespace ShopServer.Models.DTO
{
    public class DiscountDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int discount_percent { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set; }
    }
}
