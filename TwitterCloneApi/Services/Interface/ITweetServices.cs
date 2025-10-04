using TwitterCloneApi.DTOs;

namespace TwitterCloneApi.Services.Interface
{
    public interface ITweetServices
    {
        Task<List<DtoTweet>> GetAll(string? pais);

        Task<int> EditarTweet(int id, DtoTweet tweet);

        Task<bool> BajaTweet(int id);

        Task<bool> NuevoTweet(DtoTweet tweet);
    }
}
