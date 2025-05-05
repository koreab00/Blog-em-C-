using System.Security.Cryptography.X509Certificates;
using blog.Models;
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Npgsql;

internal class Program
{
    private const string CONNECTION_STRING = "Host=localhost;Port=5432;Database=blog;Username=admin;Password=SenhaForte123";

    private static void Main(string[] args)
    {
        var connection = new NpgsqlConnection(CONNECTION_STRING);
        connection.Open();
        ReadUsersWithRoles(connection);
        //CreateUsers(connection);
        //ReadRoles(connection);
        //ReadTags(connection);
        //CreateUser();
        // UpdateUser();
        // DeleteUser();
        connection.Close();
    }

    public static void ReadUsersWithRoles(NpgsqlConnection connection)
    {
        var repository = new UserRepository(connection);
        var items = repository.GetWithRoles();

        foreach (var item in items)
        {
            Console.WriteLine($"Name: {item.nome}");
            foreach (var role in item.Roles)
                Console.WriteLine($" - Role: {role.nome}");
        }
    }

    public static void CreateUsers(NpgsqlConnection connection)
    {
        var user = new Usuario
        {
            nome = "Lucas",
            email = "lucas@email.com",
            bio = "Lucas bio",
            imagem = "Lucas imagem",
            passwordhash = "hash",
            slug = "Lucas slug"
        };
        var repository = new Repository<Usuario>(connection);
        repository.Create(user);
    }

    public static void ReadRoles(NpgsqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var items = repository.Get();
        foreach (var item in items)
            Console.WriteLine($"Id: {item.id}, Name: {item.nome}, Slug: {item.slug}");
    }

    public static void ReadTags(NpgsqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var items = repository.Get();
        foreach (var item in items)
            Console.WriteLine($"Id: {item.id}, Name: {item.nome}, Slug: {item.slug}");
    }
}
