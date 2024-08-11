using Data.Entities;
using Data.Models;

namespace Data.Factories;

public static class CourseFactory
{
    public static CourseEntity Create(CourseCreateRequest request)
    {
        return new CourseEntity
        {
            ImageUri = request.ImageUri,
            ImageHeaderUri = request.ImageHeaderUri,
            Title = request.Title,
            Ingress = request.Ingress,
            Hours = request.Hours,
            IsBestSeller = request.IsBestSeller,
            LikesInNumbers = request.LikesInNumbers,
            LikesInPercent = request.LikesInPercent,
            Rating = request.Rating,
            Categories = request.Categories,
            Authors = request.Authors?.Select(a => new AuthorEntity
            {
                Name = a.Name
            }).ToList(),
            Prices = request.Prices == null ? null : new PriceEntity
            {
                Currency = request.Prices.Currency,
                Price = request.Prices.Price,
                Discount = request.Prices.Discount
            },
            Content = request.Content == null ? null : new ContentEntity
            {
                Description = request.Content.Description,
                Includes = request.Content.Includes,
                ProgramDetails = request.Content.ProgramDetails?.Select(pd => new ProgramDetailItemEntity
                {
                    Id = pd.Id,
                    Title = pd.Title,
                    Description = pd.Description
                }).ToList()
            }
        };
    }

    public static CourseEntity Update(CourseUpdateRequest request)
    {
        return new CourseEntity
        {
            Id = request.Id,
            ImageUri = request.ImageUri,
            ImageHeaderUri = request.ImageHeaderUri,
            Title = request.Title,
            Ingress = request.Ingress,
            Hours = request.Hours,
            IsBestSeller = request.IsBestSeller,
            LikesInNumbers = request.LikesInNumbers,
            LikesInPercent = request.LikesInPercent,
            Rating = request.Rating,
            Categories = request.Categories,
            Authors = request.Authors?.Select(a => new AuthorEntity
            {
                Name = a.Name
            }).ToList(),
            Prices = request.Prices == null ? null : new PriceEntity
            {
                Currency = request.Prices.Currency,
                Price = request.Prices.Price,
                Discount = request.Prices.Discount
            },
            Content = request.Content == null ? null : new ContentEntity
            {
                Description = request.Content.Description,
                Includes = request.Content.Includes,
                ProgramDetails = request.Content.ProgramDetails?.Select(pd => new ProgramDetailItemEntity
                {
                    Id = pd.Id,
                    Title = pd.Title,
                    Description = pd.Description
                }).ToList()
            }
        };
    }

    public static Course Create(CourseEntity entity)
    {
        return new Course
        {
            Id = entity.Id,
            ImageUri = entity.ImageUri,
            ImageHeaderUri = entity.ImageHeaderUri,
            Title = entity.Title,
            Ingress = entity.Ingress,
            Hours = entity.Hours,
            IsBestSeller = entity.IsBestSeller,
            LikesInNumbers = entity.LikesInNumbers,
            LikesInPercent = entity.LikesInPercent,
            Rating = entity.Rating,
            Categories = entity.Categories,
            Authors = entity.Authors?.Select(a => new Author
            {
                Name = a.Name
            }).ToList(),
            Prices = entity.Prices == null ? null : new Prices
            {
                Currency = entity.Prices.Currency,
                Price = entity.Prices.Price,
                Discount = entity.Prices.Discount
            },
            Content = entity.Content == null ? null : new Content
            {
                Description = entity.Content.Description,
                Includes = entity.Content.Includes,
                ProgramDetails = entity.Content.ProgramDetails?.Select(pd => new ProgramDetailItem
                {
                    Id = pd.Id,
                    Title = pd.Title,
                    Description = pd.Description
                }).ToList()
            }
        };
    }

}
