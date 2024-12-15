
namespace MediaLibrary.Client.Api
{
    public interface IMediaLibraryApiWrapper
    {
        Task<Actor> CreateActor(ActorDto newActor);
        Task<ActorGenre> CreateActorGenre(ActorGenreDto newActorGenre);
        Task<Album> CreateAlbum(AlbumDto newAlbum);
        Task<Genre> CreateGenre(GenreDto newGenre);
        Task<Track> CreateTrack(TrackDto newTrack);
        Task DeleteActor(int id);
        Task DeleteActorGenre(int id);
        Task DeleteAlbum(int id);
        Task DeleteGenre(int id);
        Task DeleteTrack(int id);
        Task<Actor> GetActor(int id);
        Task<ActorGenre> GetActorGenre(int id);
        Task<Album> GetAlbum(int id);
        Task<IEnumerable<AlbumInfoDto>> GetAlbumsInfo(int year);
        Task<IEnumerable<Actor>> GetAllActor();
        Task<IEnumerable<ActorGenre>> GetAllActorGenre();
        Task<IEnumerable<Album>> GetAllAlbum();
        Task<IEnumerable<Genre>> GetAllGenre();
        Task<IEnumerable<Track>> GetAllTrack();
        Task<Genre> GetGenre(int id);
        Task<IEnumerable<AlbumsActorsDto>> GetMaxAlbumsActors();
        Task<TimeAlbumDto> GetTimeAlbumsInfo();
        Task<IEnumerable<TopAlbumsDto>> GetTopAlbums();
        Task<Track> GetTrack(int id);
        Task<IEnumerable<Track>> GetTracksInAlbum(int id);
        Task UpdateActor(int id, ActorDto newActor);
        Task UpdateActorGenre(int id, ActorGenreDto newActorGenre);
        Task UpdateAlbum(int id, AlbumDto newAlbum);
        Task UpdateGenre(int id, GenreDto newGenre);
        Task UpdateTrack(int id, TrackDto newTrack);
    }
}