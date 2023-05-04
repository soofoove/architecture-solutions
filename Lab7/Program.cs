namespace Lab7;

using Lab7.Interfaces;

public static class Program
{
    public static void Main(string[] args)
    {
        IDbRepository postgreSqlRepository = DbManager.GetRepository(DbType.PostgreSql);
        IDbRepository mongoDbRepository = DbManager.GetRepository(DbType.MongoDb);

        object someData = postgreSqlRepository.Read(15);
        mongoDbRepository.Create(someData);
    }
}

