//using Android.Content;
//using Android.Content.Res;
//using Android.OS;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.Android;

//[assembly: ExportRenderer(typeof(Picker), typeof(TumblrClientApp.Droid.Renderers.CustomPickerRenderer))]
//namespace TumblrClientApp.Droid.Renderers
//{
//    public class CustomPickerRenderer : PickerRenderer
//    {
//        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
//        {
//            base.OnElementChanged(e);
//            if (Control == null || e.NewElement == null) return;
//            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
//            {
//                Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.White);
//            }
//        }

//        public CustomPickerRenderer(Context context) : base(context)
//        {
//            AutoPackage = false;

//        }
//    }
//}
