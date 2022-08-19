using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    [XmlRoot(ElementName = "resume")]
    public class Resume
    {

        [XmlElement(ElementName = "position")]
        public double Position { get; set; }

        [XmlElement(ElementName = "total")]
        public double Total { get; set; }
    }
}
