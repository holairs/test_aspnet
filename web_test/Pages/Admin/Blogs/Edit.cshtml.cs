using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using web_test.Data;
using web_test.Models.Domain;

namespace web_test.Pages.Admin.Blogs;

public class EditModel : PageModel
{
    private readonly WebDbContext webDbContext;

    [BindProperty] public BlogPost BlogPost { get; set; }

    public EditModel(WebDbContext webDbContext)
    {
        this.webDbContext = webDbContext;
    }

    public async Task OnGet(Guid id)
    {
        BlogPost = await webDbContext.BlogPosts.FindAsync(id);
    }

    public async Task<IActionResult> OnPostEdit()
    {
        var existingBlogPost = await webDbContext.BlogPosts.FindAsync(BlogPost.Id);

        if (existingBlogPost != null)
        {
            existingBlogPost.Heading = BlogPost.Heading;
            existingBlogPost.PageTitle = BlogPost.PageTitle;
            existingBlogPost.Author = BlogPost.Author;
            existingBlogPost.Content = BlogPost.Content;
            existingBlogPost.ShortDescription = BlogPost.ShortDescription;
            existingBlogPost.FeaturedImageUrl = BlogPost.FeaturedImageUrl;
            existingBlogPost.UrlHandle = BlogPost.UrlHandle;
            existingBlogPost.PublishedDate = BlogPost.PublishedDate;
            existingBlogPost.Visible = BlogPost.Visible;

            await webDbContext.SaveChangesAsync();

            return RedirectToPage("/Admin/Blogs/List");
        }

        return Page();
    }
    
    public async Task<IActionResult> OnPostDelete()
    {
        var existingBlogPost = await webDbContext.BlogPosts.FindAsync(BlogPost.Id);
        if (existingBlogPost != null)
        {
            webDbContext.BlogPosts.Remove(existingBlogPost);
            await webDbContext.SaveChangesAsync();
            return RedirectToPage("/Admin/Blogs/List");
        }
        return Page();
    }
}