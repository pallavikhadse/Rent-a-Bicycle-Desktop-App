using System.Xml.Serialization;

namespace Rent_a_Bicycle_App
{
    public class Bicycle
    {
        public string status { get; set; }
        public string category { get; set; }  // m,f,ch => male, female, child
        public string brandName { get; set; }
        public string size { get; set; }
        public int gear { get; set; }
        public string bicycleId { get; set; }
        public int tariff { get; set; }
        public int deposit { get; set; }

        [XmlIgnoreAttribute]
        public string brandAndSize { get { return $"{brandName}{" "} {size} {"''"}"; } }
        
    }
}