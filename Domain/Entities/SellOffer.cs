using Core.Enums;

namespace Domain.Entities
{
    public class SellOffer : BaseEntity
    {
        public Guid ExporterProfileId { get; set; }
        public ExporterProfile ExporterProfile { get; set; }
        public Guid CommodityId { get; set; }
        public Commodity Commodity { get; set; }
        public decimal AvailableQuantity { get; set; }
        public QuantityType QuantityUnit { get; set; }
        public decimal PricePerMtUsd { get; set; }
        public string OriginLocation { get; set; }                 // "Kano, Nigeria"
        public string Grade { get; set; }                           // "Export grade"
        public string PackagingSpec { get; set; }
        public decimal MinimumOrderMt { get; set; }
        public DeliveryTermType DeliveryTerms { get; set; }
        public ListingStatus Status { get; set; }
        public ICollection<ListingDocument> AvailableDocuments { get; set; }
    }
}
