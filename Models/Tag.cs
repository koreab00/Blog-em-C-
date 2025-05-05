using Dapper.Contrib.Extensions;

namespace blog.Models

{
    [Table("tag")]
    public class Tag
    {
        [Key]
        public int id { get; set; }
        public string? nome { get; set; }
        public string? slug { get; set; }
    }
}