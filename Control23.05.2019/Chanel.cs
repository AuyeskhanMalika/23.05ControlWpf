using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Control23._05._2019
{
    [XmlRoot(ElementName = "chanel")]
    public class Chanel
    {
        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
    }
}
