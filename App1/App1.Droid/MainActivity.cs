using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Steema.TeeChart;
using System.Drawing;

namespace App1.Droid
{
    [Activity(Label = "App1", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tagesansicht;

            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            fillGraphs();

        }

        public void fillGraphs()
        {
            Steema.TeeChart.TChart tChart1 = new Steema.TeeChart.TChart(this);
            Steema.TeeChart.Styles.Circular bar1 = new Steema.TeeChart.Styles.Circular();
            tChart1.Series.Add(bar1);
            bar1.Add(3, "Pears", Color.Red);
            bar1.Add(4, "Apples", Color.Blue);
            bar1.Add(2, "Oranges", Color.Green);
            Steema.TeeChart.Themes.BlackIsBackTheme theme = new Steema.TeeChart.Themes.BlackIsBackTheme(tChart1.Chart);
            theme.Apply();
            SetContentView(tChart1);
        }
    }
}

