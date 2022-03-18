using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using MobAvaliacao.iOS.Controll;
using UIKit;

namespace MobAvaliacao.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            //linceça syncfusion
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("@31392e342e30Sv6CJTxjhjLq6NCnQMjTEoQiMfQM+1aUrWggYKjBO3E=");

            global::Xamarin.Forms.Forms.Init();

            string dbName = "dbMobAvaliacao.db3";
            string dbPath = FileAccessHelper.GetLocalFilePath(dbName);

            // LoadApplication(new App());
            LoadApplication(new App(dbPath, dbName));

            return base.FinishedLaunching(app, options);
        }
    }
}
