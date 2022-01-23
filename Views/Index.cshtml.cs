using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VacationLog.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace VacationLog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //TODO: LOOK UP LOGGER
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
 
        public List<Vacation> vacations = Trips.History();

        public void OnGet(){} 
    }
}