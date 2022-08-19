using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    [XmlRoot(ElementName = "FileInfo")]
    public class FileInfo
    {

        [XmlElement(ElementName = "StreamDetails")]
        public StreamDetails StreamDetails { get; set; }
    }
}
