using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    [XmlRoot(ElementName = "set")]
    public class Set
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "overview")]
        public string Overview { get; set; }
    }
}
