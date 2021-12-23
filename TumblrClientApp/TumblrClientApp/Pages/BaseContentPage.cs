using Xamarin.Forms;

namespace TumblrClientApp.Pages
{
    public partial class BaseContentPage : FreshMvvm.FreshBaseContentPage
    {
        public BaseContentPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
