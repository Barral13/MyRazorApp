using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class Index : PageModel
    {
        public List<Category> Categories { get; set; } = new();
        public async Task OnGet()
        {
            await Task.Delay(2000);
            for (int i = 0; i <= 100; i++)
            {
                Categories.Add(
                    new Category(i, $"Categoria {i}", i * 18.98M)
                );
            }
        }
    }

    public record Category(
        int Id,
        string Title,
        decimal Price);
}