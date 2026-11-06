namespace VideoManipulator.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public DateTime UploadTime { get; set; }
        public int LengthInSeconds { get; set; }
        public string LengthForDisplay { get; set; }
        public string ThumbnailPath { get; set; }
        public string? Description { get; set; } = string.Empty;
    }
}
