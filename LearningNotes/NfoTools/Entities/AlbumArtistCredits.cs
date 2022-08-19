using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
	[XmlRoot(ElementName = "AlbumArtistCredits")]
	public class AlbumArtistCredits
	{

		[XmlElement(ElementName = "Artist")]
		public string Artist { get; set; }

		[XmlElement(ElementName = "MusicBrainzArtistID")]
		public string MusicBrainzArtistID { get; set; }
	}
}
