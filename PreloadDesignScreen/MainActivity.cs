using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using Android.Content;

namespace PreloadDesignScreen
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        static readonly string[] tableItems = new string[] {
        "Preload Package Scan","Preload Smart Scan Setup","Bulk Delivery Setup","Delivery Load","SPA","Beacon Maintanance"  };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            ListView listView = FindViewById<ListView>(Resource.Id.lv_simple); // get reference to the ListView in the layout

            // populate the listview with data
            listView.Adapter = new HomeScreenAdapter(this, tableItems);
            listView.ItemClick += OnListItemClick;
        }

        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = new Intent(this, typeof(PreloadPackageScan));
            StartActivity(intent);
        }
    }
    public class HomeScreenAdapter : BaseAdapter<string>
    {
        string[] items;
        Activity context;
        public HomeScreenAdapter(Activity context, string[] items) : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override string this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Length; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView; // re-use an existing view, if one is available
            if (view == null) // otherwise create a new one
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = items[position];
            return view;
        }
    }
}