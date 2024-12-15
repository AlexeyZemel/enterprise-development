using System.Runtime.InteropServices;

namespace MediaLibrary.Client.Api;

public class MediaLibraryApiWrapper(IConfiguration configuration) : IMediaLibraryApiWrapper
{
    public readonly MediaLibraryApi _client = new(configuration["OpenApi:ServerUrl"], new HttpClient());

    public async Task<Actor> CreateActor(ActorDto newActor) => await _client.ActorPOSTAsync(newActor);
    public async Task<ActorGenre> CreateActorGenre(ActorGenreDto newActorGenre) => await _client.ActorGenrePOSTAsync(newActorGenre);
    public async Task<Album> CreateAlbum(AlbumDto newAlbum) => await _client.AlbumPOSTAsync(newAlbum);
    public async Task<Genre> CreateGenre(GenreDto newGenre) => await _client.GenrePOSTAsync(newGenre);
    public async Task<Track> CreateTrack(TrackDto newTrack) => await _client.TrackPOSTAsync(newTrack);

    public async Task UpdateActor(int id, ActorDto newActor) => await _client.ActorPUTAsync(id, newActor);
    public async Task UpdateActorGenre(int id, ActorGenreDto newActorGenre) => await _client.ActorGenrePUTAsync(id, newActorGenre);
    public async Task UpdateAlbum(int id, AlbumDto newAlbum) => await _client.AlbumPUTAsync(id, newAlbum);
    public async Task UpdateGenre(int id, GenreDto newGenre) => await _client.GenrePUTAsync(id, newGenre);
    public async Task UpdateTrack(int id, TrackDto newTrack) => await _client.TrackPUTAsync(id, newTrack);

    public async Task DeleteActor(int id) => await _client.ActorDELETEAsync(id);
    public async Task DeleteActorGenre(int id) => await _client.ActorGenreDELETEAsync(id);
    public async Task DeleteAlbum(int id) => await _client.AlbumDELETEAsync(id);
    public async Task DeleteGenre(int id) => await _client.GenreDELETEAsync(id);
    public async Task DeleteTrack(int id) => await _client.TrackDELETEAsync(id);

    public async Task<Actor> GetActor(int id) => await _client.ActorGETAsync(id);
    public async Task<ActorGenre> GetActorGenre(int id) => await _client.ActorGenreGETAsync(id);
    public async Task<Album> GetAlbum(int id) => await _client.AlbumGETAsync(id);
    public async Task<Genre> GetGenre(int id) => await _client.GenreGETAsync(id);
    public async Task<Track> GetTrack(int id) => await _client.TrackGETAsync(id);

    public async Task<IEnumerable<Actor>> GetAllActor() => [.. await _client.ActorAllAsync()];
    public async Task<IEnumerable<ActorGenre>> GetAllActorGenre() => [.. await _client.ActorGenreAllAsync()];
    public async Task<IEnumerable<Album>> GetAllAlbum() => [.. await _client.AlbumAllAsync()];
    public async Task<IEnumerable<Genre>> GetAllGenre() => [.. await _client.GenreAllAsync()];
    public async Task<IEnumerable<Track>> GetAllTrack() => [.. await _client.TrackAllAsync()];

    public async Task<IEnumerable<Track>> GetTracksInAlbum(int id) => [.. await _client.TracksInAlbumAsync(id)];
    public async Task<IEnumerable<AlbumInfoDto>> GetAlbumsInfo(int year) => [.. await _client.AlbumsInfoAsync(year)];
    public async Task<IEnumerable<TopAlbumsDto>> GetTopAlbums() => [.. await _client.TopAlbumsAsync()];
    public async Task<IEnumerable<AlbumsActorsDto>> GetMaxAlbumsActors() => [.. await _client.MaxAlbumsActorsAsync()];
    public async Task<TimeAlbumDto> GetTimeAlbumsInfo() => await _client.TimeAlbumsInfoAsync();
}
