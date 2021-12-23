using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using TumblrClientApp.Enums;
using TumblrClientApp.Models.Tumblr;
using TumblrClientApp.Services.Tumblr;
using Xamarin.CommunityToolkit.ObjectModel;

namespace TumblrClientApp.PageModels
{
    public class TumblrPostsPageModel : BasePageModel
    {
        private readonly ITumblrPostsService postsService;

        #region Constructor

        public TumblrPostsPageModel(ITumblrPostsService postsService)
        {
            this.postsService = postsService;
        }

        #endregion

        #region Properties

        public List<string> PostTypes => Enum.GetNames(typeof(TumblrPostType)).ToList();

        public TumblrPostType SelectedPostType { get; set; } = TumblrPostType.Text;

        private ObservableCollection<Post> posts;
        public ObservableCollection<Post> Posts
        {
            get
            {
                return posts;
            }
            set
            {
                posts = value;
                RaisePropertyChanged(nameof(Posts));
            }
        }

        #endregion

        #region Commands

        public AsyncCommand LoadCommand => new AsyncCommand(async () =>
        {
            IsBusy = true;
            Posts = await GetPosts(SelectedPostType);
            IsBusy = false;
        });

        #endregion

        private async Task<ObservableCollection<Post>> GetPosts(TumblrPostType type)
        {
            try
            {
                Root root = await postsService.GetPosts(type).ConfigureAwait(false);
                return new ObservableCollection<Post>(root.Response.Posts);
            }
            catch
            {
                return null;
            }
        }
    }
}
