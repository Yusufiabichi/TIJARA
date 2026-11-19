using Core.Enums;

namespace Domain.Entities
{
    public class BuyerProfile : BaseEntity
    {
        public Guid UserId { get; set; }
        public string CompnayName { get; set; }
        public string CacNumber { get; set; }
        public string Tin { get; set; }
        public VerificationStatus VerificationStatus { get; set; }
    }
}
