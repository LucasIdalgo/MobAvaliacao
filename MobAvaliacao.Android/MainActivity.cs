using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using MobAvaliacao.Droid.Controll;

namespace MobAvaliacao.Droid
{
    [Activity(Label = "MobAvaliacao", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //linceça syncfusion
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("@31392e342e30Sv6CJTxjhjLq6NCnQMjTEoQiMfQM+1aUrWggYKjBO3E=");

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            string dbName = "dbMobAvaliacao.db3";
            string dbPath = FileAccessHelper.GetLocalFilePath(dbName);

            //LoadApplication(new App());
            LoadApplication(new App(dbPath, dbName));
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}