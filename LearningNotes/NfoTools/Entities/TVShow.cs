using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{


    [XmlRoot(ElementName = "tvshow")]
    public class TVShow
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "originaltitle")]
        public string OriginalTitle { get; set; }

        [XmlElement(ElementName = "showtitle")]
        public string ShowTitle { get; set; }

        [XmlElement(ElementName = "ratings")]
        public List<Rating> Ratings { get; set; }

        [XmlElement(ElementName = "UserRating")]
        public int UserRating { get; set; }

        [XmlElement(ElementName = "top250")]
        public int Top250 { get; set; }

        [XmlElement(ElementName = "season")]
        public int Season { get; set; }

        [XmlElement(ElementName = "episode")]
        public int Episode { get; set; }

        [XmlElement(ElementName = "displayseason")]
        public int DisplaySeason { get; set; }

        [XmlElement(ElementName = "displayepisode")]
        public int DisplayEpisode { get; set; }

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

        [XmlElement(ElementName = "fanart")]
        public Fanart Fanart { get; set; }

        [XmlElement(ElementName = "mpaa")]
        public string Mpaa { get; set; }

        [XmlElement(ElementName = "PlayCount")]
        public int PlayCount { get; set; }

        [XmlElement(ElementName = "LastPlayed")]
        public DateTime LastPlayed { get; set; }

        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "UniqueId")]
        public List<UniqueId> UniqueId { get; set; }

        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }

        [XmlElement(ElementName = "premiered")]
        public DateTime Premiered { get; set; }

        [XmlElement(ElementName = "year")]
        public int Year { get; set; }

        [XmlElement(ElementName = "status")]
        public string Status { get; set; }

        [XmlElement(ElementName = "code")]
        public object Code { get; set; }

        [XmlElement(ElementName = "aired")]
        public object Aired { get; set; }

        [XmlElement(ElementName = "studio")]
        public string Studio { get; set; }

        [XmlElement(ElementName = "actor")]
        public List<Actor> Actor { get; set; }

        [XmlElement(ElementName = "namedseason")]
        public NamedSeason NamedSeason { get; set; }

        [XmlElement(ElementName = "resume")]
        public Resume Resume { get; set; }

        [XmlElement(ElementName = "DateAdded")]
        public DateTime DateAdded { get; set; }
    }
}
