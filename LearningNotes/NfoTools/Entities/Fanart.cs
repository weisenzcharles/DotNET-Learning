using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    [XmlRoot(ElementName = "fanart")]
    public class Fanart
    {

        [XmlElement(ElementName = "thumb")]
        public List<Thumb> Thumb { get; set; }
    }

}
