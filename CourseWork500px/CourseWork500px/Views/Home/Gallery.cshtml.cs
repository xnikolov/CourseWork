using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseWork500px;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication1bDeletMe.Pages
{
    [Authorize]
    public class CreateModel : PageModel
    {
        
        private readonly AppDbContext _db;

        [BindProperty]
        public Photo Photo { get; set; }

        [TempData]
        public string Message { get; set; }

        private ILogger<CreateModel> _log;

        public CreateModel(AppDbContext db, ILogger<CreateModel> log)
        {
            _db = db;
            _log = log;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.Photos.Add(Photo);

            await _db.SaveChangesAsync();

            var msg = $"Customer {Photo.Name} added.";

            Message = msg;

            _log.LogCritical(msg);

            return RedirectToPage("/Gallery"); // PRG Post Redirect Get
        }
    }
}