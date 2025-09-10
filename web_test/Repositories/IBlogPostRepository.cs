using web_test.Models.Domain;

namespace web_test.Repositories;

public interface IBlogPostRepository
{
    Task<IEnumerable<BlogPost>> GetAllAsync();
    Task<BlogPost> GetAsync(Guid id);
    Task<BlogPost> AddAsync(BlogPost blogPost);
    Task<BlogPost> UpdateAsync(BlogPost blogPost);
    Task<bool> DeleteAsync(Guid id);
}