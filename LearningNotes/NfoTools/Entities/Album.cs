using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    /// <summary>
    /// 专辑。
    /// </summary>
    [XmlRoot(ElementName = "album")]
    public class Album
    {

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "musicbrainzalbumid")]
        public string MusicbrainzAlbumId { get; set; }

        [XmlElement(ElementName = "musicbrainzreleasegroupid")]
        public string MusicbrainzReleaseGroupId { get; set; }

        [XmlElement(ElementName = "scrapedmbid")]
        public bool ScrapedMBID { get; set; }

        [XmlElement(ElementName = "artistdesc")]
        public string ArtistDesc { get; set; }

        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }

        [XmlElement(ElementName = "style")]
        public string Style { get; set; }

        [XmlElement(ElementName = "mood")]
        public string Mood { get; set; }

        [XmlElement(ElementName = "theme")]
        public List<string> Theme { get; set; }

        [XmlElement(ElementName = "compilation")]
        public bool Compilation { get; set; }

        [XmlElement(ElementName = "boxset")]
        public bool Boxset { get; set; }

        [XmlElement(ElementName = "review")]
        public string Review { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "releasestatus")]
        public string ReleaseStatus { get; set; }

        [XmlElement(ElementName = "releasedate")]
        public int Releasedate { get; set; }

        [XmlElement(ElementName = "originalreleasedate")]
        public DateTime OriginalReleaseDate { get; set; }

        [XmlElement(ElementName = "label")]
        public string Label { get; set; }

        [XmlElement(ElementName = "duration")]
        public int Duration { get; set; }

        [XmlElement(ElementName = "thumb")]
        public List<Thumb> Thumb { get; set; }

        [XmlElement(ElementName = "path")]
        public object Path { get; set; }

        [XmlElement(ElementName = "rating")]
        public Rating Rating { get; set; }

        [XmlElement(ElementName = "userrating")]
        public UserRating UserRating { get; set; }

        [XmlElement(ElementName = "votes")]
        public int Votes { get; set; }

        [XmlElement(ElementName = "albumArtistCredits")]
        public AlbumArtistCredits AlbumArtistCredits { get; set; }

        [XmlElement(ElementName = "releasetype")]
        public string ReleaseType { get; set; }
    }
}
