using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MyApp
{
    [Activity(MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.MyButton);
            EditText login = FindViewById<EditText>(Resource.Id.edLogin);
            EditText senha = FindViewById<EditText>(Resource.Id.edSenha);

            button.Click += delegate
            {
                Intent intent = new Intent(this, typeof(SegundaTelaActivity));

                intent.PutExtra("login", login.Text);
                intent.PutExtra("senha", senha.Text);
                StartActivity(intent);
            };
        }
    }
}

