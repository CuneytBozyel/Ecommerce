using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Model;
using Ecommerce.Models;

namespace Ecommerce.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly Ecommerce.Models.EcommerceContext _context;

        public IndexModel(Ecommerce.Models.EcommerceContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
