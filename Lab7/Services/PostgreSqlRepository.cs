namespace Lab7.Services
{
    using Lab7.Interfaces;

    public class PostgreSqlRepository : IDbRepository
    {
        private static PostgreSqlRepository _instance;

        public static IDbRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PostgreSqlRepository();
            }

            return _instance;
        }

        public void Create(object value)
        {
            throw new NotImplementedException();
        }

        public object Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(object value)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        private PostgreSqlRepository()
        {
        }
    }
}
