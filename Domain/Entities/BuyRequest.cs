using Core.Enums;

namespace Domain.Entities
{
    public class BuyRequest : BaseEntity
    {
        public Guid BuyerProfileId { get; set; }
        public BuyerProfile BuyerProfile { get; set; }
        public Guid CommodityId { get; set; }
        public Commodity Commodity { get; set; }
        public decimal Quantity { get; set; }
        public QuantityType QuantityUnit { get; set; }  // "Kilogram", "Gram", "MetricTon", "Bag", "Sack", "Carton"
        public decimal TargetPricePerMtUsd { get; set; }
        public string OriginCountry { get; set; }
        public string DestinationPort { get; set; }               // "Jebel Ali, UAE"
        public string PackagingSpec { get; set; }                  // "50kg bags"
        public int DeliveryWithinDays { get; set; }
        public string? PaymentTerms { get; set; }                  // nullable = "negotiable"
        public string QualitySpecNotes { get; set; }                // moisture/cleanliness/pesticide text for now
        public ListingStatus Status { get; set; }
        public DateTime ExpiresAt { get; set; }
        public ICollection<RequiredDocument> RequiredDocuments { get; set; }
    }
}
