namespace BlazorMusicCatalogCourse.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; } = null!;
        public byte[] CoverImage { get; set; } = null!;
        public string Author { get; set; } = null!;
        public List<Song> Songs { get; set; } = null!;
    }
}
