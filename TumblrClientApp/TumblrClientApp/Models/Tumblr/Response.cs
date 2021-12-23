using System.Collections.Generic;

namespace TumblrClientApp.Models.Tumblr
{
    public class Response
    {
        public Blog blog { get; set; }
        public List<Post> Posts { get; set; }
        public int total_posts { get; set; }
    }
}
