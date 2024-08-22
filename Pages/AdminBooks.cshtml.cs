using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Bibliosharp.Pages
{
    public class AdminBooks : PageModel
    {
        private readonly ILogger<AdminBooks> _logger;

        public AdminBooks(ILogger<AdminBooks> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}