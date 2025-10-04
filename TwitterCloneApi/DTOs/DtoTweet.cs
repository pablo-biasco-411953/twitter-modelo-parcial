using TwitterCloneApi.Models;

namespace TwitterCloneApi.DTOs
{
    public class DtoTweet
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime PublishDatetime { get; set; }

        public bool IsPublic { get; set; }

        public DtoUsuarios User { get; set; }
    }
}
