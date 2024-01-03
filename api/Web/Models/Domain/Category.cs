using System.ComponentModel.DataAnnotations;

namespace Web.Models.Domain;

public class Category
{
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public string? UrlHandle { get; set; }

}
