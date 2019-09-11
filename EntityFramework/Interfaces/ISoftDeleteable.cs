namespace EntityFramework.Interfaces
{
    public interface ISoftDeleteable
    {
        bool IsDeleted { get; set; }
    }
}