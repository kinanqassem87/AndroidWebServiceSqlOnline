using Android.App;
using Android.Widget;
using Android.OS;

namespace adduserwebservice
{
    [Activity(Label = "adduserwebservice", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText txtfname;
        EditText txtlname;
        Button btnadd;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            txtfname = FindViewById<EditText>(Resource.Id.txtfname);
            txtlname = FindViewById<EditText>(Resource.Id.txtlname);
            btnadd = FindViewById<Button>(Resource.Id.btnAdd);
            btnadd.Click += Btnadd_Click;
        }

        private void Btnadd_Click(object sender, System.EventArgs e)
        {
            if (!txtfname.Text.Equals("") && !txtlname.Text.Equals(""))
            {
                AddService.WebService ws = new AddService.WebService();
                ws.RegisterCompleted += Ws_RegisterCompleted;
                ws.RegisterAsync(txtfname.Text, txtlname.Text);
                txtfname.Text = txtlname.Text = "";
            }
        }

        private void Ws_RegisterCompleted(object sender, AddService.RegisterCompletedEventArgs e)
        {
            Toast.MakeText(this,e.Result.Message, ToastLength.Long).Show();
        }
    }
}

