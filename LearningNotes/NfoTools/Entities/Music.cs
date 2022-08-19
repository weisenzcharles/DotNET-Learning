using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{

    [XmlRoot(ElementName = "musicvideo")]
    public class Music
    {

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "UserRating")]
        public int UserRating { get; set; }

        [XmlElement(ElementName = "top250")]
        public int Top250 { get; set; }

        [XmlElement(ElementName = "track")]
        public int Track { get; set; }

        [XmlElement(ElementName = "album")]
        public string Album { get; set; }

        [XmlElement(ElementName = "outline")]
        public object Outline { get; set; }

        [XmlElement(ElementName = "plot")]
        public string Plot { get; set; }

        [XmlElement(ElementName = "tagline")]
        public object Tagline { get; set; }

        [XmlElement(ElementName = "runtime")]
        public int Runtime { get; set; }

        [XmlElement(ElementName = "thumb")]
        public List<Thumb> Thumb { get; set; }

        [XmlElement(ElementName = "mpaa")]
        public object Mpaa { get; set; }

        [XmlElement(ElementName = "PlayCount")]
        public int PlayCount { get; set; }

        [XmlElement(ElementName = "LastPlayed")]
        public object LastPlayed { get; set; }

        [XmlElement(ElementName = "id")]
        public object Id { get; set; }

        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }

        [XmlElement(ElementName = "year")]
        public int Year { get; set; }

        [XmlElement(ElementName = "status")]
        public object Status { get; set; }

        [XmlElement(ElementName = "director")]
        public List<string> Director { get; set; }

        [XmlElement(ElementName = "code")]
        public object Code { get; set; }

        [XmlElement(ElementName = "aired")]
        public object Aired { get; set; }

        [XmlElement(ElementName = "trailer")]
        public object Trailer { get; set; }

        [XmlElement(ElementName = "fileinfo")]
        public FileInfo Fileinfo { get; set; }

        [XmlElement(ElementName = "artist")]
        public string Artist { get; set; }

        [XmlElement(ElementName = "resume")]
        public Resume Resume { get; set; }

        [XmlElement(ElementName = "DateAdded")]
        public DateTime DateAdded { get; set; }
    }
}
