using Web.Models.Domain;

namespace Web.Repositories.Contracts;

public interface ICategoryRepository
{
    Task<Category> CreateAsync(Category category);

}
