using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyApp
{
    [Activity(Label = "SegundaTelaActivity")]
    public class SegundaTelaActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);

            SetContentView(Resource.Layout.SegundaTela);

            TextView loginResult = FindViewById<TextView>(Resource.Id.tvLoginResult);
            TextView senhaResult = FindViewById<TextView>(Resource.Id.tvSenhaResult);

            loginResult.Text = Intent.GetStringExtra("login") ?? string.Empty;
            senhaResult.Text = Intent.GetStringExtra("senha") ?? string.Empty;

            Button buttonBack = FindViewById<Button>(Resource.Id.btnBack);
            Button buttonFoward = FindViewById<Button>(Resource.Id.btnFoward);

            buttonBack.Click += delegate
            {
                Intent mainIntent = new Intent(this, typeof(MainActivity));
                StartActivity(mainIntent);
                Finish();
            };

            buttonFoward.Click += delegate
            {
                Intent intent = new Intent(this, typeof(TerceiraTelaActivity));

                StartActivity(intent);
            };
        }
    }
}