using FreshMvvm;
using TumblrClientApp.PageModels;
using TumblrClientApp.Services.Tumblr;
using Xamarin.Forms;

namespace TumblrClientApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FreshIOC.Container.Register<ITumblrPostsService, TumblrPostsService>();
            var page = FreshPageModelResolver.ResolvePageModel<TumblrPostsPageModel>();
            var basicNavContainer = new FreshNavigationContainer(page);
            MainPage = basicNavContainer;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

    public class ExtendedWebView : WebView { }
}
