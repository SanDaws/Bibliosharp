using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Bibliosharp.Pages
{
    public class AdminEmployed : PageModel
    {
        private readonly ILogger<AdminEmployed> _logger;

        public AdminEmployed(ILogger<AdminEmployed> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}