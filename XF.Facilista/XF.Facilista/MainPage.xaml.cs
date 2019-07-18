using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Facilista
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();
        

        private void ButtonEntrarClicked(object sender, EventArgs e) 
            => Navigation.PushAsync(new Pages.ListsPage());
    }
}
