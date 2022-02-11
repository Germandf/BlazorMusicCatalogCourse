using BlazorMusicCatalogCourse.Models;

namespace BlazorMusicCatalogCourse.Data.Services
{
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAlbums();
        Task<Album?> GetAlbum(int id);
        Task<bool> InsertAlbum(Album album);
        Task<bool> UpdateAlbum(Album album);
        Task<bool> DeleteAlbum(Album album);
    }
}
