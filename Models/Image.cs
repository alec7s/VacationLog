namespace VacationLog.Models
{
    public class Image
    {
        public int Id { get; set; }
        private string _Path { get; set; }
        public string Caption { get; set; }
        public string AltText { get; set; }

        public Image(int id, string caption, string altText)
        {
            Id = id;
            Caption = caption;
            AltText = altText;
        }

        public void setPath(string page) {
            _Path = $"~/Assets/Highlights/{page}.jpg";
        }
    }
}
