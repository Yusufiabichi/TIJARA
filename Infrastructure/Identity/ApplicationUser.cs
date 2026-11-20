using Core.Constants;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public RolesConstant Role { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ExporterProfile? ExporterProfile { get; set; }
        public BuyerProfile? BuyerProfile { get; set; }
    }
}