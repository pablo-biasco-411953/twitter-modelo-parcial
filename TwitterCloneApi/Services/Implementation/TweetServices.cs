using TwitterCloneApi.DTOs;
using TwitterCloneApi.Repositories.Interface;
using TwitterCloneApi.Services.Interface;

namespace TwitterCloneApi.Services.Implementation
{
    public class TweetServices : ITweetServices
    {
        private readonly ITweetRepository _tweetrepository;

        public TweetServices(ITweetRepository tweetRepository)
        {
            _tweetrepository = tweetRepository;
        }
        public Task<bool> BajaTweet(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> EditarTweet(int id, DtoTweet tweet)
        {
            throw new NotImplementedException();
        }

        public Task<List<DtoTweet>> GetAll(string? pais)
        {
            return _tweetrepository.GetAll(pais);
        }

        public Task<bool> NuevoTweet(DtoTweet tweet)
        {
            throw new NotImplementedException();
        }
    }
}
