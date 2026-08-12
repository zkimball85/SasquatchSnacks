using System.ComponentModel.DataAnnotations;

namespace SasquatchSnacks.Models;

public class Customer
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string FirstName { get; set; } = null!;

    [Required]
    [StringLength(100)]
    public string LastName { get; set; } = null!;

    [Required]
    [StringLength(100)]
    public string Email { get; set; } = null!;
}
