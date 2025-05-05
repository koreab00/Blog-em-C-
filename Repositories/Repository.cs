using Dapper.Contrib.Extensions;
using Npgsql;
using System.Collections.Generic;

namespace Blog.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly NpgsqlConnection _connection;
        public Repository(NpgsqlConnection connection)
        => _connection = connection;

        public IEnumerable<T> Get()
        => _connection.GetAll<T>();

        public T Get(int id)
        => _connection.Get<T>(id);

        public void Create(T model)
        => _connection.Insert<T>(model);

        public void Update(T model)
        => _connection.Get<T>(model);

        public void Delete(T model)
        => _connection.Get<T>(model);

        public void Delete(int id)
        {
            var model = _connection.Get<T>(id);
            _connection.Get<T>(model);
        }
    }
}
