using System.Collections.ObjectModel;
using XF.Facilista.Entities;

namespace XF.Facilista.ViewModels
{
    public class MarketViewModel : Market
    {
        public ObservableCollection<Market> Markets { get; set; }
        // Mock dos dados para produtos
        public MarketViewModel()
        {
            Markets = new ObservableCollection<Market>
            {
                new Market() { ID = 0, Name = "Super Mercado Extra", Description = "Descrição do mercado", Address = "Av Radial leste, 3654 - São Paulo"},
                new Market() { ID = 1, Name = "Sonda Super Mercado", Description = "Descrição do mercado", Address = "Av Celso Garcia, 4384 - Tatuapé - São Paulo/SP"},
                new Market() { ID = 2, Name = "Açai", Description = "Descrição do mercado", Address = "N/I"}
            };
        }
    }
}
