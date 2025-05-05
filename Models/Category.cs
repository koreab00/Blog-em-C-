using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("category")]
    public class Category
    {
        public Category()
        => Posts = new List<Post>();
        public int id { get; set; }
        public string? nome { get; set; }
        public string? slug { get; set; }
        public List<Post> Posts { get; set; }
    }
}