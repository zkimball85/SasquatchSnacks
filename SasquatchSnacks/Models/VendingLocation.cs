using System.ComponentModel.DataAnnotations;

namespace SasquatchSnacks.Models;

/// <summary>
/// Represents a vending location where Sasquatch Snacks 
/// automated vending machines are located and their products are available for purchase.
/// </summary>
public class VendingLocation
{
    // The Id is a required field and will be used as the primary key
    [Key]
    public int Id { get; set; }

    // The location name is a required field and will be used to identify
    // the vending location.
    [Required]
    public string LocationName { get; set; } = null!;

    // The address is an optional field and will be used to provide the
    // physical address of the vending location.
    public string? Address { get; set; }

    // The operating hours is an optional field and will be used to provide
    // the hours of operation for the vending location.
    public required string OperatingHours { get; set; } = null!;

    // The isPubliclyAccessible is a required field and will be used to determine
    // if the vending location is accessible to the public or not.
    public bool IsPubliclyAccessible { get; set; }
}
