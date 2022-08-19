using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    [XmlRoot(ElementName = "thumb")]
    public class Thumb
    {

        [XmlAttribute(AttributeName = "spoof")]
        public object Spoof { get; set; }

        [XmlAttribute(AttributeName = "cache")]
        public object Cache { get; set; }

        [XmlAttribute(AttributeName = "aspect")]
        public string Aspect { get; set; }

        [XmlAttribute(AttributeName = "preview")]
        public object Preview { get; set; }

        [XmlAttribute(AttributeName = "colors")]
        public object Colors { get; set; }
    }
}
