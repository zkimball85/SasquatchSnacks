using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SasquatchSnacks.Models;

/// <summary>
/// Represents a consumable product offered by 
/// Sasquatch Snacks that can be purchased by customers.
/// </summary>
public class ConsumableProduct
{
    // The Id is a required field and will be used as the primary key
    // for the ConsumableProduct table in the database.
    [Key]
    public int Id { get; set; }

    // The product name is a required field and will be used to identify the product being sold.
    [Required]
    public string ProductName { get; set; } = null!;

    // The product description is a required field and will be used to provide more information about the product being sold.
    [Required]
    public string Category { get; set; } = null!;

    // The price is a required field and will be used to determine the cost of the product.
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    // The stock quantity is a required field and will be used to determine
    public int StockQuantity { get; set; }
}
