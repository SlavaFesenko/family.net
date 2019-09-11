namespace EntityFramework.Interfaces
{
    public interface IEntity : ISoftDeleteable
    {
        int ID { get; set; }
    }
}