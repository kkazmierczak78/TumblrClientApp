using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TumblrClientApp.Models.Tumblr
{
    public class Post
    {
        public string type { get; set; }
        public string blog_name { get; set; }
        public Blog blog { get; set; }
        public long Id { get; set; }
        public string id_string { get; set; }
        [JsonPropertyName("post_url")]
        public string PostUrl { get; set; }
        public string slug { get; set; }
        public string date { get; set; }
        public int timestamp { get; set; }
        public string state { get; set; }
        public string format { get; set; }
        public string reblog_key { get; set; }
        public List<object> tags { get; set; }
        [JsonPropertyName("short_url")]
        public string ShortUrl { get; set; }
        public string summary { get; set; }
        public bool should_open_in_legacy { get; set; }
        public object recommended_source { get; set; }
        public object recommended_color { get; set; }
        public int note_count { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public Reblog reblog { get; set; }
        //public List<Trail> trail { get; set; }
        public bool can_like { get; set; }
        public string interactability_reblog { get; set; }
        public bool can_reblog { get; set; }
        public bool can_send_in_message { get; set; }
        public bool can_reply { get; set; }
        public bool display_avatar { get; set; }
    }
}
