using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobAvaliacao
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        /*public static class Globais
        {
            public static ModelConfiguracao _configuracao = new ModelConfiguracao();
        }*/

        public static string dbName;
        public static string dbPath;

        public App(string dbpath, string dbname)
        {
            //linceça syncfusion
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("@31392e342e30Sv6CJTxjhjLq6NCnQMjTEoQiMfQM+1aUrWggYKjBO3E=");
            InitializeComponent();
            dbName = dbname;
            dbPath = dbpath;

            MainPage = new NavigationPage(new MainPage());
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
}
