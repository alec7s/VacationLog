namespace VacationLog.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string? Path { get; set; }
        public string Caption { get; set; }
        public string AltText { get; set; }

        public Image(int id, string caption, string altText)
        {
            Id = id;
            Caption = caption;
            AltText = altText;
        }
    }
}
