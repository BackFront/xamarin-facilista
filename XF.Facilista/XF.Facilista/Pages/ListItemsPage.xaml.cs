using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Facilista.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListItemsPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListItemsPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Lista de compras mensal",
                "Churrasco aniversário",
                "Open house"
            };
			
			Lista.ItemsSource = Items;
        }

        //async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    if (e.Item == null)
        //        return;

        //    await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

        //    //Deselect Item
        //    ((ListView)sender).SelectedItem = null;
        //}
        async void ListaClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Pages.MercadoriaListPage());

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        //async void ListaAddClicked(object sender, EventArgs e) => await DisplayAlert("Nova lista", "Criar nova lista", "OK");

        async void ListaAddClicked(object sender, EventArgs e) => Navigation.PushAsync(new Pages.ListsPage());
    }
}
