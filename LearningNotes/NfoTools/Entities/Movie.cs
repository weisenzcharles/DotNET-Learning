using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    /// <summary>
    /// 电影。
    /// </summary>
    [XmlRoot(ElementName = "movie")]
    public class Movie
    {

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "originaltitle")]
        public string OriginalTitle { get; set; }

        [XmlElement(ElementName = "sorttitle")]
        public string SortTitle { get; set; }

        [XmlElement(ElementName = "ratings")]
        public List<Rating> Ratings { get; set; }

        [XmlElement(ElementName = "userrating")]
        public int UserRating { get; set; }

        [XmlElement(ElementName = "top250")]
        public int Top250 { get; set; }

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

        [XmlElement(ElementName = "playcount")]
        public int PlayCount { get; set; }

        [XmlElement(ElementName = "lastplayed")]
        public object LastPlayed { get; set; }

        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "uniqueid")]
        public List<UniqueId> UniqueId { get; set; }

        [XmlElement(ElementName = "genre")]
        public List<string> Genre { get; set; }

        [XmlElement(ElementName = "tag")]
        public List<string> Tag { get; set; }

        [XmlElement(ElementName = "set")]
        public Set Set { get; set; }

        [XmlElement(ElementName = "country")]
        public string Country { get; set; }

        [XmlElement(ElementName = "credits")]
        public string Credits { get; set; }

        [XmlElement(ElementName = "premiered")]
        public DateTime Premiered { get; set; }

        [XmlElement(ElementName = "year")]
        public int Year { get; set; }

        [XmlElement(ElementName = "status")]
        public object Status { get; set; }

        [XmlElement(ElementName = "code")]
        public object Code { get; set; }

        [XmlElement(ElementName = "aired")]
        public object Aired { get; set; }

        [XmlElement(ElementName = "studio")]
        public List<string> Studio { get; set; }

        [XmlElement(ElementName = "Poster")]
        public List<string> Posters { get; set; }

        [XmlElement(ElementName = "banners")]
        public List<string> Banners { get; set; }

        [XmlElement(ElementName = "Clearlogo")]
        public List<string> Clearlogos { get; set; }

        [XmlElement(ElementName = "trailer")]
        public object Trailer { get; set; }

        [XmlElement(ElementName = "fileinfo")]
        public FileInfo FileInfo { get; set; }

        [XmlElement(ElementName = "actor")]
        public List<Actor> Actor { get; set; }

        [XmlElement(ElementName = "director")]
        public Director Director { get; set; }

        [XmlElement(ElementName = "resume")]
        public Resume Resume { get; set; }

        [XmlElement(ElementName = "dateadded")]
        public DateTime DateAdded { get; set; }
    }

}
