using BlazorMusicCatalogCourse.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Album?> GetAlbum(int id)
        {
            return await _context.Albums
                .Where(x => x.Id == id)
                .Include(x => x.Songs)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Album>> GetAlbums()
        {
            return await _context.Albums.ToListAsync();
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
