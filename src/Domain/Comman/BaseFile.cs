namespace Domain.Comman;

public class BaseFile : BaseEntity, ICreatedDate
{
    public string FileName { get; set; }
    public string Path { get; set; }
    public string Storage { get; set; }
    public DateTime CreatedDate { get; set; }
}


