using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Net_swag_ordering_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwaggPage : ContentPage
    { 
      public SwaggPage()
        {
            InitializeComponent();
            BindingContext = new Net_swagitemPage();


        }
        private void OnSaveClicked(object sender, EventArgs e)
        {
            var item = BindingContext as SwaggItem;
            var databse = SwaggDatabase.Instance;
            database.SaveSwagItem(item);
        }

        private void OrderItemsButton_Clicked(object sender, EventArgs e)
        {
            Navigate.PushAsync(new MainPage());

        }
            
        
    }
}