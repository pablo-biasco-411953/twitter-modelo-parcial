using TwitterCloneApi.Models;

namespace TwitterCloneApi.DTOs
{
    public class DtoUsuarios
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public bool IsActive { get; set; }

        public DtoPaises Pais { get; set; } = new();



    }
}
