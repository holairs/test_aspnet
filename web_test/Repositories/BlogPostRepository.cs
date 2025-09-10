using web_test.Data;
using web_test.Models.Domain;

namespace web_test.Repositories;

public class BlogPostRepository : IBlogPostRepository
{
    public BlogPostRepository(WebDbContext webContext) { }

    public Task<IEnumerable<BlogPost>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<BlogPost> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<BlogPost> AddAsync(BlogPost blogPost)
    {
        throw new NotImplementedException();
    }

    public Task<BlogPost> UpdateAsync(BlogPost blogPost)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}

