using Core.Enums;

namespace Domain.Entities
{
    public class ExporterProfile : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string CompanyName { get; set; }
        public string CacNumber { get; set; }
        public string Tin { get; set; }
        public string? NepcLicenseNumber { get; set; }
        public VerificationStatus VerificationStatus { get; set; }
        public FulfillmentRating FulfillmentRating { get; set; }
        public ICollection<SellOffers> SellOffers { get; set; }

    }
}
