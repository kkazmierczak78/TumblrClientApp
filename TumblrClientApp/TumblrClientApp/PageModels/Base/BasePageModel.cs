namespace TumblrClientApp.PageModels
{
    public class BasePageModel : FreshMvvm.FreshBasePageModel
    {
        bool isBusy = false;
        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                if (isBusy != value)
                {
                    isBusy = value;
                    RaisePropertyChanged(nameof(IsBusy));
                }
            }
        }
    }
}
