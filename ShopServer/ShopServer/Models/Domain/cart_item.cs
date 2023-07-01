namespace ShopServer.Models.Domain
{
    public class cart_item
    {
        public Guid id { get; set; }
        public Guid? ProductId { get; set; }
        public int quantity { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set; }
    }
}
