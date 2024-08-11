namespace Data.Models;

public class CourseUpdateRequest
{
    public string Id { get; set; } = null!;
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
    public virtual List<AuthorUpdateRequest>? Authors { get; set; }
    public virtual PriceUpdateRequest? Prices { get; set; }
    public virtual ContentUpdateRequest? Content { get; set; }
}

public class AuthorUpdateRequest
{
    public string? Name { get; set; }
}

public class PriceUpdateRequest
{
    public string? Currency { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
}

public class ContentUpdateRequest
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public virtual List<ProgramDetailItemUpdateRequest>? ProgramDetails { get; set; }
}

public class ProgramDetailItemUpdateRequest
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}