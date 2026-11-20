using Core.Enums;

namespace Domain.Entities
{
    public class BuyerProfile : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string CompanyName { get; set; }
        public string? CacNumber { get; set; }
        public VerificationStatus VerificationStatus { get; set; }
        public ICollection<BuyRequest> BuyRequests { get; set; }
    }
}
