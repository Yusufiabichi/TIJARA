using Core.Enums;

namespace Domain.Entities
{
    public class Contract : BaseEntity
    {
        public Guid ExporterId { get; set; }
        public Guid BuyerId { get; set; }
        public CommodityType CommodityType { get; set; }
        public QuantityType QuantityType { get; set; }
        public string Quantity { get; set; }
        public string AgreedPriceNgn { get; set; }
        public EntityStatus Status { get; set; }
    }
}
