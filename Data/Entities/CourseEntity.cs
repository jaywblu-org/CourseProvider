using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class CourseEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? ImageUri { get; set; }
    public string? ImageHeaderUri { get; set; }
    public string? Title { get; set; }
    public string? Ingress { get; set; }
    public int Hours { get; set; }
    public bool IsBestSeller { get; set; }
    public string? LikesInNumbers { get; set; }
    public string? LikesInPercent { get; set; }
    public decimal Rating { get; set; }
    public string[]? Categories { get; set; }
    public virtual List<AuthorEntity>? Authors { get; set; }
    public virtual PriceEntity? Prices { get; set; }
    public virtual ContentEntity? Content { get; set; }

}
