using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    internal class EscrowAccount :BaseEntity
    {
        public Guid ContractId { get; set; }
        public string ProviderReference { get; set; } = null!;
        public EntityStatus Status { get; set; }
    }
}
