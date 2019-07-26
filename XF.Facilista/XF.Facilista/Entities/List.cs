using System.Collections.Generic;

namespace XF.Facilista.Entities
{
    public class Lists
    {
        public int              ID { get; set; }
        public string           Name { get; set; }
        public string           Description { get; set; }
        public List<Product>    Products { get; set; }
        public int[]            ProductsChecked { get; set; }
    }
}
