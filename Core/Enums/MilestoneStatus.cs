using System.ComponentModel.DataAnnotations;

namespace Core.Enums
{
    public enum MilestoneStatus
    {
        Pending = 1,
        InProgress = 2,
        [Display(Name = "Awaiting Approval")]
        AwaitingApproval = 3,
        Completed = 4,
        Funded = 5,
        [Display(Name = "Funds Released")]
        FundsReleased = 6,
        Rejected = 7,
        OnHold = 8,
    }
}