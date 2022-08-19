using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    [XmlRoot(ElementName = "subtitle")]
    public class Subtitle
    {

        [XmlElement(ElementName = "language")]
        public string Language { get; set; }
    }
}
