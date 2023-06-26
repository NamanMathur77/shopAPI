namespace ShopServer.Models.DTO
{
    public class UpdateProductRequestDto
    {
        public string name { get; set; }
        public string desc { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public DateTime modified_at { get; set; }
        public Guid? DiscountId { get; set; }
        //public DiscountDto? discount { get; set; }

    }
}
