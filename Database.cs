using Npgsql;

namespace Blog
{
    public static class Database
    {
        private const string CONNECTION_STRING = "Host=localhost;Port=5432;Database=blog;Username=admin;Password=SenhaForte123";

        public static NpgsqlConnection Connection
        => new NpgsqlConnection(CONNECTION_STRING);
    }
}