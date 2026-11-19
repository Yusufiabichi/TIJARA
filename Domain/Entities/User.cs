using Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //public RolesConstant Role { get; set; }
        public UserType UserType { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public Genders Gender { get; set; }
        public DateTime? ModifiedOn { get; set; } = DateTime.UtcNow;
        public DateTime? CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? DateOfBirth { get; set; }
        public string CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return string.Join(" ", new[] { FirstName, MiddleName, Surname }.Where(name => !string.IsNullOrWhiteSpace(name)));
            }
        }
    }
}
