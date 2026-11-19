using Core.Enums;

namespace Domain.Entities
{
    public class Document :BaseEntity
    {
        public Guid ContractId { get; set; }
        public DocumentType Type { get; set; }
        public string FileUrl { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}
