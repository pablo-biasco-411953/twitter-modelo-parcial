using Microsoft.EntityFrameworkCore;
using TwitterCloneApi.DTOs;
using TwitterCloneApi.Models;
using TwitterCloneApi.Repositories.Interface;

namespace TwitterCloneApi.Repositories.Implementation
{
    public class TweetRepository : ITweetRepository
    {
        //aca en el repository va el context
        private readonly TwitterCloneContext _context;

        public TweetRepository(TwitterCloneContext context)
        {
               _context = context;
        }
        public Task<bool> BajaTweet(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> EditarTweet(int id, DtoTweet tweet)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DtoTweet>> GetAll(string? pais)
        {
            List<DtoTweet> listTweet = new List<DtoTweet>();

            var bdtweets = await _context.Tweets.Include(p => p.IdUserNavigation)
                .Where(p=> p.IdUserNavigation.IdCountryNavigation.Country1 ==pais).ToListAsync();

            foreach (var bdtweet in bdtweets)
            {
                DtoTweet t = new DtoTweet();
                t.Id = bdtweet.Id;
                t.PublishDatetime = bdtweet.PublishDatetime;
                t.User.Id = bdtweet.IdUserNavigation.Id;
                t.User.Username = bdtweet.IdUserNavigation.Username;
                t.IsPublic = bdtweet.IsPublic;
                t.Content = bdtweet.Content;
                listTweet.Add(t);
            }

            return listTweet;
        }

        public Task<bool> NuevoTweet(DtoTweet tweet)
        {
            throw new NotImplementedException();
        }
    }
}
