using System.Collections.ObjectModel;
using XF.Facilista.Entities;

namespace XF.Facilista.ViewModels
{
    public class ProductViewModel : Product
    {
        public string AmountStr => Amount.ToString();
        public string PriceStr => Price.ToString();

        public ObservableCollection<Product> Products { get; set; }
        // Mock dos dados para produtos
        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product() { ID = 0, Name = "Produto teste", Description = "Descrição do produto", UnitMeasurement = Enumerators.UnitMeasurement.Unidade, Amount = 3 },
                new Product() { ID = 1, Name = "Produto 02", Description = "Descrição do produto", UnitMeasurement = Enumerators.UnitMeasurement.Litro, Amount = 1 },
                new Product() { ID = 2, Name = "Alcatra Freeboi", Description = "Peça de carne Alcatra", UnitMeasurement = Enumerators.UnitMeasurement.Quilograma, Amount = 1.5 }
            };
        }
    }
}
