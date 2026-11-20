using Core.Enums;

namespace Domain.Entities
{
    public class Commodity : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }              
        public CommodityType Category { get; set; }
    }
}
