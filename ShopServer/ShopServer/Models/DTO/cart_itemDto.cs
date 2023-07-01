namespace ShopServer.Models.DTO
{
    public class cart_itemDto
    {
        public Guid id { get; set; }
        public Guid? ProductId { get; set; }
        public int quantity { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set; }
    }
}
