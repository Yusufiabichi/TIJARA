using Core.Enums;

namespace Domain.Entities
{
    public class LedgerEntry : BaseEntity
    {
        public Guid EscrowAccountId { get; set; }
        public LedgerDirection Direction { get; set; }
        public decimal AmountNgn { get; set; }
        public string? Reason { get; set; }
        public string? ExternalTnxId { get; set; }
    }
}