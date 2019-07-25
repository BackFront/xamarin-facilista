using System.Collections.Generic;

namespace XF.Facilista.Entities
{
    class List
    {
        public int              ID { get; set; }
        public string           Name { get; set; }
        public string           Description { get; set; }
        public List<Product>    Products { get; set; }
        public List<int>        ProductsChecked { get; set; }
    }
}
