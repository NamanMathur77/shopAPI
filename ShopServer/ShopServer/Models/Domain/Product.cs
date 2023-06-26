using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Reflection.Metadata.Ecma335;

namespace ShopServer.Models.Domain
{
    public class Product
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public DateTime create_at { get; set; }
        public DateTime modified_at { get; set; }
        public Guid? DiscountId { get; set; }

        public Discount? discount { get; set; }

    }
}
