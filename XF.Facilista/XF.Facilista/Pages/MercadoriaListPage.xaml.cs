using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Facilista.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MercadoriaListPage : ContentPage
	{
        public ObservableCollection<string> Mercadorias { get; set; }

        public MercadoriaListPage()
		{
			InitializeComponent();

            Mercadorias = new ObservableCollection<string>
            {
                "Carne",
                "Cerveja",
                "Refrigerante"
            };

            Itens.ItemsSource = Mercadorias;
        }

        //async void MercadoriaClicked(object sender, ItemTappedEventArgs e)
        //{
        //    if (e.Item == null) return;

        //    await DisplayAlert("Clicou na mercadoria", "Mostar os detalhes da mercadoria clicada", "OK");

        //    ((ListView)sender).SelectedItem = null;
        //}

        async void MercadoriaClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Pages.MercadoriaUpdatePage());

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}