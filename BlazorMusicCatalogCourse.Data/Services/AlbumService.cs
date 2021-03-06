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

        public async Task<bool> DeleteAlbum(Album album)
        {
            _context.Remove(album);
            return await _context.SaveChangesAsync() > 0;
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

        public async Task<bool> UpdateAlbum(Album album)
        {
            _context.Update(album);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
