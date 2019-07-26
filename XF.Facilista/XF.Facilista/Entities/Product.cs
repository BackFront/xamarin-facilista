using SQLite;
using XF.Facilista.Enumerators;

namespace XF.Facilista.Entities
{
    //[Table("TB_PRODUCTS")]
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int              ID { get; set; }
        public string           Name { get; set; }
        public string           Description { get; set; }
        public string           Brand { get; set; }
        public int              Barcode { get; set; }
        public float            Price { get; set; }
        public Market           Market { get; set; }
        public double           Amount { get; set; }
        public UnitMeasurement  UnitMeasurement { get; set; }
    }
}
