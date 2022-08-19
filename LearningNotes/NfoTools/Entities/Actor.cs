using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    /// <summary>
    /// 演员。
    /// </summary>
    [XmlRoot(ElementName = "actor")]
    public class Actor
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "role")]
        public string Role { get; set; }

        [XmlElement(ElementName = "order")]
        public int Order { get; set; }

        [XmlElement(ElementName = "thumb")]
        public string Thumb { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "tmdbid")]
        public int Tmdbid { get; set; }

        [XmlElement(ElementName = "imdbid")]
        public string Imdbid { get; set; }
    }
}
