using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{

    [XmlRoot(ElementName = "streamdetails")]
    public class StreamDetails
    {

        [XmlElement(ElementName = "video")]
        public Video Video { get; set; }

        [XmlElement(ElementName = "audio")]
        public List<Audio> Audio { get; set; }

        [XmlElement(ElementName = "subtitle")]
        public Subtitle Subtitle { get; set; }
    }
}
