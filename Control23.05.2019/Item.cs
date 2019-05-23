using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Control23._05._2019
{
    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "currency")]
        public string Currency { get; set; }

        [XmlElement(ElementName = "denomination")]
        public double? Denomination { get; set; }

        [XmlElement(ElementName = "change")]
        public double? Change { get; set; }

        [XmlElement(ElementName = "index")]
        public string Index { get; set; }
    }
}
