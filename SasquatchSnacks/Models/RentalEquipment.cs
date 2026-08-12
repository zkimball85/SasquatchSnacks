using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SasquatchSnacks.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SasquatchSnacks.Models;

/// <summary>
/// Represents a piece of equipment offered by Sasquatch Snacks that can be rented by customers.
/// </summary>
public class RentalEquipment
{
    // The Id is a required field and will be used as the primary key for the RentalEquipment table in the database.
    [Key]
    public int Id { get; set; }

    // The name is a required field and will be used to identify the equipment being rented.
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    // The description is a required field and will be used to provide more information about the equipment being rented.
    [StringLength(200)]
    public string Description { get; set; } = null!;

    // The daily rate is a required field and will be used to calculate the total cost of the rental based on the number of days the equipment is rented for.
    [Column(TypeName = "decimal(18, 2)")]
    public decimal DailyRate { get; set; }

    // The security deposit is a required field and will be used to cover any damages or losses that may occur during the rental period.
    [Column(TypeName = "decimal(18, 2)")]
    public decimal SecurityDeposit { get; set; }

    // This property will be used to determine if the equipment is available for rental or not.
    public bool IsActive { get; set; }

    // This property will be used to establish a one-to-many relationship between RentalEquipment and RentalBooking.
    public ICollection<RentalBooking> Bookings { get; set; } = new List<RentalBooking>();
}
