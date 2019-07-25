using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Facilista.Entities;
using XF.Facilista.ViewModels;

namespace XF.Facilista.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductUpdate : ContentPage
    {
        public ProductViewModel produtosVM = new ProductViewModel();

        public ProductUpdate()
        {
            InitializeComponent();
            BindingContext = produtosVM;
        }

        private void SearchInList(object sender, TextChangedEventArgs e)
        {
            string search = ProductsSearchBar.Text;
            if (String.IsNullOrEmpty(search)) ProductsListView.ItemsSource = null;

            ProductsListView.ItemsSource = produtosVM.Products.Where(x => x.Name.ToLower().Contains(search.ToLower()));
        }

        private void ProductsListView_ItemClicked(object sender, ItemTappedEventArgs e) => Navigation.PushAsync(new Pages.ProductDetail());
    }
}