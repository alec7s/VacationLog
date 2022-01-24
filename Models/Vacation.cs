namespace VacationLog.Models
{
    public class Vacation
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Page { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
        public List<Image> Images { get; set; }
        public List<string> Description { get; set; }
        public Vacation(int id, string author, string page, string title, int year, string month, List<Image> images, List<string> description)
        {
            Id = id;
            Author = author;
            Page = page;
            Title = title;
            Year = year;
            Month = month;
            Images = images;
            Description = description;
            
            foreach(Image img in images)
            {
                img.Path = $"~/Assets/{page}/{img.Id}-{page}.jpg";
            }
        }
    }
}
