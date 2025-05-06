using Blog;
using Blog.Screens.TagScreens;
using Npgsql;

internal class Program
{
    // private const string CONNECTION_STRING = "Host=localhost;Port=5432;Database=blog;Username=admin;Password=SenhaForte123";

    private static void Main(string[] args)
    {
        // Database.Connection = new NpgsqlConnection(CONNECTION_STRING);
        Database.Connection.Open();

        Load();

        Console.ReadKey();
        Database.Connection.Close();
    }

    private static void Load()
    {
        Console.Clear();
        Console.WriteLine("Meu Blog");
        Console.WriteLine("--------------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Gestão de usuário");
        Console.WriteLine("2 - Gestão de perfil");
        Console.WriteLine("3 - Gestão de categoria");
        Console.WriteLine("4 - Gestão de tag");
        Console.WriteLine("5 - Vincular perfil/usuário");
        Console.WriteLine("6 - Vincular post/tag");
        Console.WriteLine("7 - Relatórios");
        Console.WriteLine();
        Console.WriteLine();
        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                MenuTagScreen.Load();
                break;
            case 2:
                MenuTagScreen.Load();
                break;
            case 3:
                MenuTagScreen.Load();
                break;
            case 4:
                MenuTagScreen.Load();
                break;
            default: Load(); break;
        }

    }
}
