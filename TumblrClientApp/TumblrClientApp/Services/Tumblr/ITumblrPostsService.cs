using System.Threading.Tasks;
using TumblrClientApp.Models.Tumblr;

namespace TumblrClientApp.Services.Tumblr
{
    public interface ITumblrPostsService
    {
        Task<Root> GetPosts();
        Task<Root> GetPosts(Enums.TumblrPostType type);
        Task<Root> GetPosts(string blogIdentifier, Enums.TumblrPostType type);
        Task<Root> GetPosts(string blogIdentifier, Enums.TumblrPostType type, string api_key);
    }
}
