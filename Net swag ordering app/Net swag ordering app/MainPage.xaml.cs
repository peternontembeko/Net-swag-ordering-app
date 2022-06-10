using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Net_swag_ordering_app
{
    public partial class MainPage : ContentPage
    {
        private List<SwagItem> _dotNetSwag;

        public List<SwagItem> DotNetSwag
        {
            get { return _dotNetSwag; }
            set { _dotNetSwag = value; }
        }

        public MainPage()
        {
            InitializeComponent();


        }

        protected override void OnApperaring()
        {

            base.OnApperaring();
            var database = SwagDatabase.Instance;
            DotNetSwag = database.GetDotNetSwag();
            BindingContext = this;
        }

        private void SwagApplistView_ItemTapped(objetc sender, ItemTappedEventArgs e)
        {


        }

    }
}
