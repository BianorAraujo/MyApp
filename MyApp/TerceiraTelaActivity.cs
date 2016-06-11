
using Android.App;
using Android.OS;

namespace MyApp
{
    [Activity(Label = "TerceiraTelaActivity")]
    public class TerceiraTelaActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TerceiraTela);
        }
    }
}