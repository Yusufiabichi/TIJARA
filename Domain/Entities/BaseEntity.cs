using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public BaseEntity()
        {
            Id = Guid.CreateVersion7();
            IsDeleted = false;
            Status = EntityStatus.Active;
            ModifiedOn = DateTime.UtcNow;
            CreatedOn = DateTime.UtcNow;
        }
    }
}
