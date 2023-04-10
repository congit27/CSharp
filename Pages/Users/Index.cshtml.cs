using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DocumentUser.Models;

namespace DocumentUser.Pages.Shared.Users
{
    public class IndexModel : PageModel
    {
        private readonly DocumentUser.Data.DocumentUserContext _context;

        public IndexModel(DocumentUser.Data.DocumentUserContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                User = await _context.Users.ToListAsync();
            }
        }
    }
}
