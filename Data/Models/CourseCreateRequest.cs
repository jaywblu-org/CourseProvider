namespace Data.Models;

public class CourseCreateRequest
{
    public string? ImageUri { get; set; }
    public string? ImageHeaderUri { get; set; }
    public string? Title { get; set; }
    public string? Ingress { get; set; }
    public string? Price { get; set; }
    public int Hours { get; set; }
    public bool IsBestSeller { get; set; }
    public string? LikesInNumbers { get; set; }
    public string? LikesInPercent { get; set; }
    public decimal Rating { get; set; }
    public string[]? Categories { get; set; }
    public virtual List<AuthorCreateRequest>? Authors { get; set; }
    public virtual PriceCreateRequest? Prices { get; set; }
    public virtual ContentCreateRequest? Content { get; set; }
}

public class AuthorCreateRequest
{
    public string? Name { get; set; }
}

public class PriceCreateRequest
{
    public string? Currency { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
}

public class ContentCreateRequest
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public virtual List<ProgramDetailItemCreateRequest>? ProgramDetails { get; set; }
}

public class ProgramDetailItemCreateRequest
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}