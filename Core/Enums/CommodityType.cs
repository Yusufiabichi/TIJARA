using System.ComponentModel.DataAnnotations;

namespace Core.Enums
{
    public enum CommodityType
    {
        [Display(Name = "Grains")]
        Grains = 1,
        [Display(Name = "Oilseeds")]
        Oilseeds = 2,
        [Display(Name = "Pulses")]
        Pulses = 3,
        [Display(Name = "Nuts")]    
        Nuts = 4,
        [Display(Name = "Roots and Tubers")]
        RootsAndTubers = 5,
        [Display(Name = "Fruits")]
        Fruits = 6,
        [Display(Name = "Vegetables")]
        Vegetables = 7,
        [Display(Name = "Fibres")]
        Fibres = 8,
        [Display(Name = "Cash Crops")]
        CashCrops = 9,
        [Display(Name = "Processed Agricultural Products")]
        ProcessedAgriculturalProducts = 10,
        [Display(Name = "Other")]
        Other = 99
    }
}