using System.ComponentModel.DataAnnotations;

namespace Web.Models.Domain;

public class BlogPost
{
    public Guid Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    public string? ShortDescription { get; set; }
    [Required]
    public string Content { get; set; } = string.Empty;
    public string? FeaturedImageUrl { get; set; }
    public string? UrlHandle { get; set; }
    public DateTime PublishedDate { get; set; }
    [Required]
    public string Author { get; set; } = string.Empty;
    public bool IsVisible { get; set; } = true;
}
