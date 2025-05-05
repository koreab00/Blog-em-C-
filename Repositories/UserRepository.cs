using Blog.Models;
using Dapper;
using Npgsql;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Repositories
{
    public class UserRepository : Repository<Usuario>
    {
        private readonly NpgsqlConnection _connection;
        public UserRepository(NpgsqlConnection connection)
        : base(connection)
        => _connection = connection;

        public List<Usuario> GetWithRoles()
        {
            var query = @"
                SELECT 
                    usuario.*,
                    roles.*
                FROM usuario
                    LEFT JOIN userrole ON userrole.userid = usuario.id
                    LEFT JOIN roles on userrole.roleid = roles.id";

            var users = new List<Usuario>();

            var items = _connection.Query<Usuario, Role, Usuario>(
                query,
                (user, role) =>
                {
                    var usr = users.FirstOrDefault(x => x.id == user.id);
                    if (usr == null)
                    {
                        usr = user;
                        if (role != null)
                            usr.Roles.Add(role);
                        users.Add(usr);
                    }
                    else
                        usr.Roles.Add(role);

                    return user;
                }, splitOn: "id");

            return users;
        }
    }
}