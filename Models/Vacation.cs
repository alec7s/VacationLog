namespace VacationLog.Models
{
    public class Vacation
    {
        public string Page { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
        public List<string> ImageAltTexts { get; set; }
        public List<string> ImageCaptions { get; set; }
        public List<string> Description { get; set; }
        public Vacation(string page, string title, int year, string month, List<string> imageAltTexts, List<string> imageCaptions, List<string> description)
        {
            Page = page;
            Title = title;
            Year = year;
            Month = month;
            ImageAltTexts = imageAltTexts;
            ImageCaptions = imageCaptions;
            Description = description;
        }
    }
}
