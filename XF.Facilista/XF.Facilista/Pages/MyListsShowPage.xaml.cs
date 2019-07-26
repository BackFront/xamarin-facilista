using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Facilista.Entities;
using XF.Facilista.ViewModels;

namespace XF.Facilista.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyListsShowPage : ContentPage
    {
        public ObservableCollection<Product> itemsSelecteds { get; set; }
        public ProductViewModel produtosVM = new ProductViewModel();

        public MyListsShowPage()
        {
            InitializeComponent();

            itemsSelecteds = new ObservableCollection<Product>();

            MyListProductsView.ItemsSource = produtosVM.Products;
            MyListProductsSelectedsView.ItemsSource = itemsSelecteds;
        }

        void MyListShowAddProductClicked(object sender, ItemTappedEventArgs e)
        {
            var selecionado = (Product)e.Item;

            produtosVM.Products.Remove(selecionado);
            MyListProductsView.ItemsSource = produtosVM.Products;

            itemsSelecteds.Add(selecionado);
            MyListProductsSelectedsView.ItemsSource = itemsSelecteds;

            ((ListView)sender).SelectedItem = null;
        }

        void MyListShowRemoveProductClicked(object sender, ItemTappedEventArgs e)
        {
            var selecionado = (Product)e.Item;

            itemsSelecteds.Remove(selecionado);
            MyListProductsSelectedsView.ItemsSource = itemsSelecteds;

            produtosVM.Products.Add(selecionado);
            MyListProductsView.ItemsSource = produtosVM.Products;

            ((ListView)sender).SelectedItem = null;
        }

        void MyListShowSaveClicked(object sender, EventArgs e) => throw new NotImplementedException();
    }
}
