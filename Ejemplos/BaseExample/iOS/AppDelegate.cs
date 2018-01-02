using BaseExample.iOS.ViewControllers;
using Foundation;
using UIKit;

namespace BaseExample.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        UINavigationController navController;

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            App.Initialize();

            navController = new UINavigationController(new BrowseViewController());
            Window = new UIWindow(UIScreen.MainScreen.Bounds);

            Window.RootViewController = navController;
            Window.MakeKeyAndVisible();

            return true;
        }
    }
}
