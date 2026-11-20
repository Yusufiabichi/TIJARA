using Core.Enums;

namespace Domain.Entities
{
    public class RequiredDocument : BaseEntity
    {
        public Guid BuyRequestId { get; set; }
        public BuyRequest BuyRequest { get; set; }
        public DocumentType Type { get; set; }
    }
}
