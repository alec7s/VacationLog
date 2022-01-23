using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VacationLog.Pages
{
    public class cmsModel : PageModel
    {
        [BindProperty]
        public string Title { get; set; }
        public string Name { get; set; }

        [BindProperty]
        public int Year { get; set; }

        [BindProperty]
        public string Month { get; set; }

        [BindProperty]
        public string Description { get; set; }

        public List<string> ImageFileNames { get; set; }
        public List<string> ImageAltTexts { get; set; }
        public List<string> ImageCaptions { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}
