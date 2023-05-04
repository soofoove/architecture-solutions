using Lab7.Interfaces;

namespace Lab7
{
    using Lab7.Services;

    public class DbManager
    {
        public static IDbRepository GetRepository(DbType type)
        {
            switch(type)
            {
                case DbType.PostgreSql:
                    return PostgreSqlRepository.GetInstance();

                case DbType.MongoDb: 
                    return MongoDbRepository.GetInstance();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
