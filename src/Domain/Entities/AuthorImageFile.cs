using Domain.Comman;

namespace Domain.Entities
{
    public class AuthorImageFile : BaseFile
    {
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
    }
}


