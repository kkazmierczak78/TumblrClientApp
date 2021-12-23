using Refit;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using TumblrClientApp.Config;
using TumblrClientApp.Enums;
using TumblrClientApp.Models.Tumblr;

namespace TumblrClientApp.Services.Tumblr
{
    public class TumblrPostsService : ITumblrPostsService
    {
        /// <summary>
        /// Gets Tumblr text posts for default blog identifier and default API key
        /// </summary>
        /// <returns>Root object which contains Tumblr posts</returns>
        public async Task<Root> GetPosts()
        {
            return await Posts(Consts.BlogIdentifier, TumblrPostType.Text, Consts.APIKey);
        }

        /// <summary>
        /// Gets Tumblr posts for specified type, default blog identifier and default API key
        /// </summary>
        /// <param name="type">The type of post to return. Specify one of the following: text, quote, link, answer, video, audio, photo, chat</param>
        /// <returns>Root object which contains Tumblr posts</returns>
        public async Task<Root> GetPosts(TumblrPostType type)
        {
            return await Posts(Consts.BlogIdentifier, type, Consts.APIKey);
        }

        /// <summary>
        /// Gets Tumblr posts for specified blog identifier, type and default API key
        /// </summary>
        /// <param name="blogIdentifier">Any blog identifier</param>
        /// <param name="type">The type of post to return. Specify one of the following: text, quote, link, answer, video, audio, photo, chat</param>
        /// <returns>Root object which contains Tumblr posts</returns>
        public async Task<Root> GetPosts(string blogIdentifier, TumblrPostType type)
        {
            return await Posts(blogIdentifier, type, Consts.APIKey);
        }

        /// <summary>
        /// Gets Tumblr posts for specified blog identifier, type and API key
        /// </summary>
        /// <param name="blogIdentifier">Any blog identifier</param>
        /// <param name="type">The type of post to return. Specify one of the following: text, quote, link, answer, video, audio, photo, chat</param>
        /// <param name="apiKey">Your OAuth Consumer Key</param>
        /// <returns>Root object which contains Tumblr posts</returns>
        public async Task<Root> GetPosts(string blogIdentifier, TumblrPostType type, string apiKey)
        {
            return await Posts(blogIdentifier, type, apiKey);
        }

        private async Task<Root> Posts(string blogIdentifier, TumblrPostType type, string apiKey)
        {
            try
            {
                var options = new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true,
                };

                var settings = new RefitSettings()
                {
                    ContentSerializer = new SystemTextJsonContentSerializer(options)
                };

                ITumblrRestApi _restClient = RestService.For<ITumblrRestApi>(Consts.APIUrl, settings);
                return await _restClient.Posts(blogIdentifier, type.ToString().ToLower(), apiKey).ConfigureAwait(false);
            }
            catch
            {
                return null;
            }
        }
    }
}
