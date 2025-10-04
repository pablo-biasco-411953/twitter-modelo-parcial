using TwitterCloneApi.DTOs;

namespace TwitterCloneApi.Repositories.Interface
{
    public interface ITweetRepository
    {
        Task<List<DtoTweet>> GetAll(string? pais);

        Task<int>  EditarTweet(int id, DtoTweet tweet);

        Task<bool> BajaTweet(int id);

        Task<bool> NuevoTweet(DtoTweet tweet);
    }
}
