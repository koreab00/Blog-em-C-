using Dapper.Contrib.Extensions;
using System;

namespace Blog.Models
{
    [Table("post")]
    public class Post
    {
        [Key]
        public int id { get; set; }
        public int categoryid { get; set; }
        public int authorid { get; set; }
        public string? title { get; set; }
        public string? summary { get; set; }
        public string? body { get; set; }
        public string? slug { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}