using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    [XmlRoot(ElementName = "rating")]
    public class Rating
    {

        [XmlElement(ElementName = "value")]
        public double Value { get; set; }

        [XmlElement(ElementName = "votes")]
        public int Votes { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "max")]
        public int Max { get; set; }

        [XmlAttribute(AttributeName = "default")]
        public bool Default { get; set; }

        [XmlText]
        public double Text { get; set; }
    }
}
