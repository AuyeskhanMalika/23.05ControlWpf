using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Control23._05._2019
{
    [XmlRoot(ElementName = "rss")]
    public class Valute
    {
        [XmlElement(ElementName = "chanel")]
        public Chanel chanel { get; set; }
    }
}
