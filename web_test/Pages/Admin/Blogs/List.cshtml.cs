using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using web_test.Data;
using web_test.Models.Domain;

namespace web_test.Pages.Admin.Blogs
{
    public class ListModel : PageModel
    {
        private readonly WebDbContext webDbContext;

        public List<BlogPost> BlogPosts { get; set; }

        public ListModel(WebDbContext webDbContext)
        {
            this.webDbContext = webDbContext;
        }

        public async Task OnGet()
        {
            BlogPosts = await webDbContext.BlogPosts.ToListAsync();
        }
    }
}