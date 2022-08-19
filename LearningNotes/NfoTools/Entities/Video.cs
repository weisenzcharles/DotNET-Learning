using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
    /// <summary>
    /// 视频信息。
    /// </summary>
    [XmlRoot(ElementName = "video")]
    public class Video
    {

        [XmlElement(ElementName = "codec")]
        public string Codec { get; set; }

        [XmlElement(ElementName = "micodec")]
        public string Micodec { get; set; }

        [XmlElement(ElementName = "bitrate")]
        public int Bitrate { get; set; }

        [XmlElement(ElementName = "width")]
        public int Width { get; set; }

        [XmlElement(ElementName = "height")]
        public int Height { get; set; }

        [XmlElement(ElementName = "aspect")]
        public string Aspect { get; set; }

        [XmlElement(ElementName = "aspectratio")]
        public string Aspectratio { get; set; }

        [XmlElement(ElementName = "framerate")]
        public double Framerate { get; set; }

        [XmlElement(ElementName = "language")]
        public string Language { get; set; }

        [XmlElement(ElementName = "scantype")]
        public string Scantype { get; set; }

        [XmlElement(ElementName = "default")]
        public bool Default { get; set; }

        [XmlElement(ElementName = "forced")]
        public bool Forced { get; set; }

        [XmlElement(ElementName = "duration")]
        public int Duration { get; set; }

        /// <summary>
        /// 持续时间（以秒为单位）。
        /// </summary>
        [XmlElement(ElementName = "durationinseconds")]
        public int DurationInSeconds { get; set; }

        [XmlElement(ElementName = "stereomode")]
        public object StereoMode { get; set; }
    }
}
