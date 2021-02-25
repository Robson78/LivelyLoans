using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LivelyLoans.Pages
{
    public class ApplyModel : PageModel
    {
        private readonly ILogger<ApplyModel> _logger;

        public ApplyModel(ILogger<ApplyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
