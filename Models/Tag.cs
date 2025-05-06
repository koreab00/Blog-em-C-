using Dapper.Contrib.Extensions;

namespace Blog.Models

{
    [Table("tag")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Slug { get; set; }
    }
}