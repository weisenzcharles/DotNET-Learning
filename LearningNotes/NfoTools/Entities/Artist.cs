using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    /// <summary>
    /// 艺术家。
    /// </summary>
    [XmlRoot(ElementName = "artist")]
    public class Artist
    {
        /// <summary>
        /// 名称。
        /// </summary>
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// MusicBrainz 艺术家编号。
        /// </summary>
        [XmlElement(ElementName = "MusicBrainzArtistID")]
        public string MusicBrainzArtistID { get; set; }

        [XmlElement(ElementName = "SortName")]
        public string SortName { get; set; }

        /// <summary>
        /// 类型。
        /// </summary>
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// 性别。
        /// </summary>
        [XmlElement(ElementName = "gender")]
        public string Gender { get; set; }

        [XmlElement(ElementName = "disambiguation")]
        public object Disambiguation { get; set; }

        /// <summary>
        /// 流派。
        /// </summary>
        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }

        /// <summary>
        /// 风格。
        /// </summary>
        [XmlElement(ElementName = "style")]
        public List<string> Style { get; set; }

        /// <summary>
        /// 情绪。
        /// </summary>
        [XmlElement(ElementName = "mood")]
        public List<string> Mood { get; set; }

        [XmlElement(ElementName = "yearsactive")]
        public string YearsActive { get; set; }

        [XmlElement(ElementName = "born")]
        public DateTime Born { get; set; }

        [XmlElement(ElementName = "formed")]
        public int Formed { get; set; }

        [XmlElement(ElementName = "biography")]
        public string Biography { get; set; }

        [XmlElement(ElementName = "died")]
        public object Died { get; set; }

        [XmlElement(ElementName = "disbanded")]
        public object Disbanded { get; set; }

        /// <summary>
        /// 缩略图。
        /// </summary>
        [XmlElement(ElementName = "thumb")]
        public List<Thumb> Thumb { get; set; }

        /// <summary>
        /// 路径。
        /// </summary>
        [XmlElement(ElementName = "path")]
        public string Path { get; set; }
    }
}
