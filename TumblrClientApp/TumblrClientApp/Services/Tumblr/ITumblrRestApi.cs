using Refit;
using System.Threading.Tasks;
using TumblrClientApp.Models.Tumblr;

namespace TumblrClientApp.Services.Tumblr
{
    //https://api.tumblr.com/v2/blog/t0r02006/posts/text?api_key=InYIlA8RLPnsH5n0LZjntbjDGr52sB5kLJpbeC3NNfP4OxRFNa
    public interface ITumblrRestApi
    {
        [Get("/v2/blog/{blog_identifier}/posts/{type}?api_key={api_key}")]
        Task<Root> Posts(string blog_identifier, string type, string api_key);
    }
}
