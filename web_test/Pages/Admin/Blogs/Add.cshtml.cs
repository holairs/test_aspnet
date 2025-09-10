using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using web_test.Data;
using web_test.Models.Domain;
using web_test.Models.ViewModels;

namespace web_test.Pages.Admin.Blogs;

public class Add : PageModel
{
    [BindProperty] public AddBlogPost AddBlogPostRequest { get; set; }
    private readonly WebDbContext webDbContext;

    public Add(WebDbContext webDbContext)
    {
        this.webDbContext = webDbContext;
    }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost()
    {
        var blogPost = new BlogPost()
        {
            Heading = AddBlogPostRequest.Heading,
            PageTitle = AddBlogPostRequest.PageTitle,
            Content = AddBlogPostRequest.Content,
            ShortDescription = AddBlogPostRequest.ShortDescription,
            FeaturedImageUrl = AddBlogPostRequest.FeaturedImageUrl,
            UrlHandle = AddBlogPostRequest.UrlHandle,
            PublishedDate = AddBlogPostRequest.PublishedDate,
            Author = AddBlogPostRequest.Author,
            Visible = AddBlogPostRequest.Visible
        };

        await webDbContext.BlogPosts.AddAsync(blogPost);
        webDbContext.SaveChangesAsync();
        
        return RedirectToPage("/Admin/Blogs/List");
    }
}
