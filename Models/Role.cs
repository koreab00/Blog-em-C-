using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("roles")]
    public class Role
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? slug { get; set; }
    }
}