using Core.Enums;

namespace Domain.Entities
{
    public class ListingDocument : BaseEntity
    {
        public Guid SellOfferId { get; set; }
        public SellOffer SellOffer { get; set; }
        public DocumentType Type { get; set; }
        public string FileUrl { get; set; }
        public VerificationStatus VerificationStatus { get; set; }  // admin can verify an uploaded cert
        public DateTime UploadedAt { get; set; }
    }
}
