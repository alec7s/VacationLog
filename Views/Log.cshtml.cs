
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using VacationLog.Models;
using System.Web;

namespace VacationLog.Pages
{
    public class LogModel : PageModel
    {
        public List<Vacation> vacationHistory = Trips.History();
        public Vacation vacation;
        public void OnGet(string? title)
        {
            //FIND PAGE CONTENT FROM TRIP HISTORY
            vacation = vacationHistory.Find(x => x.Page == title);
        }
    }
}
