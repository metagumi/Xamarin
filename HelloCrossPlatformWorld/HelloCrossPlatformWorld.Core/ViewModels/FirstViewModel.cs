using MvvmCross.Core.ViewModels;

namespace HelloCrossPlatformWorld.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        string hello = "Hello Xamarin in Action, Again";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }
    }
}
