using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LivelyLoans.Pages
{
    public class TreatingModel : PageModel
    {
        private readonly ILogger<TreatingModel> _logger;

        public TreatingModel(ILogger<TreatingModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
