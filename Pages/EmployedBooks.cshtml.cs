using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Bibliosharp.Pages
{
    public class EmployedBooks : PageModel
    {
        private readonly ILogger<EmployedBooks> _logger;

        public EmployedBooks(ILogger<EmployedBooks> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}