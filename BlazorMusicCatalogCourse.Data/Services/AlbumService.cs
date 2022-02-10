using BlazorMusicCatalogCourse.Models;

namespace BlazorMusicCatalogCourse.Data.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly BlazorMusicCatalogCourseContext _context;

        public AlbumService(BlazorMusicCatalogCourseContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetAlbum(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Album>> GetAlbums()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAlbum(Album album)
        {
            _context.Add(album);
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<bool> UpdateAlbum(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
