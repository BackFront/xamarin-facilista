using System.Collections.ObjectModel;
using Xamarin.Forms;
using XF.Facilista.Entities;

namespace XF.Facilista.ViewModels
{
    public class ListViewModel : Lists
    {
        public ObservableCollection<Lists> Lists { get; set; }

        // Mock dos dados para Listas
        public ListViewModel()
        {
            Lists = new ObservableCollection<Lists>
            {
                new Lists() { ID = 0, Name = "Lista de Compras Mensal", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit", ProductsChecked = new int[] { 1, 3}},
                new Lists() { ID = 1, Name = "Churrasco de Aniversário", Description = "Duis aute irure dolor in reprehenderit in voluptate velit" },
                new Lists() { ID = 2, Name = "Open house", Description = "Esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa" },
                new Lists() { ID = 3, Name = "Ceia de natal", Description = "qui officia deserunt mollit anim id est laborum" }
            };
        }

        #region commands
        public Command<Lists> RemoveCommand
        {
            get
            {
                return new Command<Lists>((list) =>
                {
                    Lists.Remove(list);
                });
            }
        }
        #endregion
    }
}
