using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Facilista.ViewModels;

namespace XF.Facilista.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetail : ContentPage
    {
        public MarketViewModel varejistasVM = new MarketViewModel();
        public ProductViewModel produtosVM = new ProductViewModel();

        public ProductDetail()
        {
            InitializeComponent();
            MarketsListView.ItemsSource = varejistasVM.Markets;
            //ProductsListView = produtosVM;
        }

        private void MarketsListView_ItemClicked(object sender, ItemTappedEventArgs e) => throw new NotImplementedException();

        private void SearchInMarketList(object sender, TextChangedEventArgs e)
        {
            string search = ProductsSearchBar.Text;
            if (String.IsNullOrEmpty(search)) MarketsListView.ItemsSource = null;

            MarketsListView.ItemsSource = varejistasVM.Markets.Where(x => x.Name.ToLower().Contains(search.ToLower()));
        }
    }
}