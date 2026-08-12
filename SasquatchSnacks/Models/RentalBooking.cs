using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SasquatchSnacks.Models;
/// <summary>
/// Represents a booking for a piece of equipment rented by a customer.
/// </summary>
public class RentalBooking
{
    // The Id is a required field and will be used as the primary key
    // for the RentalBooking table in the database.
    [Key]
    public int Id { get; set; }

    // The start date is a required field and will be used to determine
    // the rental period for the equipment being rented.
    public DateTime StartDate { get; set; }

    // The end date is a required field and will be used to determine
    public DateTime EndDate { get; set; }

    // The total cost is a required field and will be used to calculate
    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalCost { get; set; }

    // The status is a required field and will be used to determine the current
    public string Status { get; set; } = null!;

    // The customer id is a required field and will be used to establish a
    // relationship with the Customer model
    public int CustomerId { get; set; }

    // The customer property is a required field and will be used to
    // establish a relationship with the Customer model
    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; } = null!;

    // The rental equipment id is a required field and will be used to
    // establish a relationship with the RentalEquipment model
    public int RentalEquipmentId { get; set; }

    // The rental equipment property is a required field and will be used to
    // establish a relationship with the RentalEquipment model
    [ForeignKey("RentalEquipmentId")]
    public RentalEquipment RentalEquipment { get; set; } = null!;
}
