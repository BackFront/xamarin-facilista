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
    public partial class MyListsPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListViewModel minasListasVM = new ListViewModel();

        public MyListsPage()
        {
            InitializeComponent();

            MyListView.ItemsSource = minasListasVM.Lists;
        }

        private void SearchInMyLists(object sender, TextChangedEventArgs e)
        {
            string search = MyListsSearchBar.Text;
            if (String.IsNullOrEmpty(search)) MyListView.ItemsSource = null;

            MyListView.ItemsSource = minasListasVM.Lists.Where(x => x.Name.ToLower().Contains(search.ToLower()));
        }

        async void MyListItemClicked(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;

            await Navigation.PushAsync(new Pages.MyListsShowPage());

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        void MyListItemDeletClicked(object sender, ClickedEventArgs e)
        {
            var selecionado = e;

            foreach (var i in MyListView.ItemsSource)
            {
                var t = i;
            }
        }

        async void MyListAddClicked(object sender, EventArgs e) => await Navigation.PushAsync(new Pages.MyListsAddPage());

        async void MyListItemEditClicked(object sender, EventArgs e) => await Navigation.PushAsync(new Pages.MyListsEditPage());

        private void MyListItemRemoveClicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;

            if (menuItem != null)
            {
                var list = menuItem.BindingContext as Lists;
                var vm = BindingContext as ListViewModel;

                minasListasVM.Lists.Remove(list);
            }
        }
    }
}
