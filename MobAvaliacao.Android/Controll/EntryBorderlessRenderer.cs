using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MobAvaliacao.Controll;
using MobAvaliacao.Droid.Controll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryBorderless), typeof(EntryBorderlessRenderer))]
namespace MobAvaliacao.Droid.Controll
{
    public class EntryBorderlessRenderer : EntryRenderer
    {
        public EntryBorderlessRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
                Control.Background = null;
        }
    }
}