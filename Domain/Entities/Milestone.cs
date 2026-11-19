using Core.Enums;

namespace Domain.Entities
{
    public class Milestone : BaseEntity
    {
        public Guid ContractId { get; set; }
        public MilestoneType Type { get; set; }
        public MilestoneStatus Status { get; set; }
        public int SequenceOrder { get; set; }
    }
}
