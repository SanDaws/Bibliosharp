using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Bibliosharp.Pages
{
    public class Register : PageModel
    {
        private readonly ILogger<Register> _logger;

        public Register(ILogger<Register> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}