using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
	/// <summary>
	/// 音频信息。
	/// </summary>
    [XmlRoot(ElementName = "audio")]
    public class Audio
    {

		[XmlElement(ElementName = "codec")]
		public string Codec { get; set; }

		[XmlElement(ElementName = "micodec")]
		public string Micodec { get; set; }

		[XmlElement(ElementName = "bitrate")]
		public int Bitrate { get; set; }

		[XmlElement(ElementName = "language")]
		public string Language { get; set; }

		[XmlElement(ElementName = "scantype")]
		public string Scantype { get; set; }

		[XmlElement(ElementName = "channels")]
		public int Channels { get; set; }

		[XmlElement(ElementName = "samplingrate")]
		public int Samplingrate { get; set; }

		[XmlElement(ElementName = "default")]
		public bool Default { get; set; }

		[XmlElement(ElementName = "forced")]
		public bool Forced { get; set; }
	}
}
