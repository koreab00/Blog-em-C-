using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("usuario")]
    public class Usuario
    {
        public Usuario()
        => Roles = new List<Role>();

        public int id { get; set; }
        public string? nome { get; set; }
        public string? email { get; set; }
        public string? passwordhash { get; set; }
        public string? bio { get; set; }
        public string? imagem { get; set; }
        public string? slug { get; set; }

        [Write(false)]
        public List<Role> Roles { get; set; }
    }
}