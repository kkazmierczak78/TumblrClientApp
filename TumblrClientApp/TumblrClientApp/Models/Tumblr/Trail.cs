using System;
using System.Collections.Generic;
using System.Text;

namespace TumblrClientApp.Models.Tumblr
{
    public class Trail
    {
        public Blog blog { get; set; }
        public Post post { get; set; }
        public string content_raw { get; set; }
        public string content { get; set; }
        public bool is_current_item { get; set; }
        public bool is_root_item { get; set; }
    }
}
