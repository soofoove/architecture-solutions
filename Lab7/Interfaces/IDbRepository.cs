namespace Lab7.Interfaces
{
    public interface IDbRepository
    {
        void Create(object value);

        object Read(int id);

        void Update(object value);

        void Delete(int id);
    }
}
