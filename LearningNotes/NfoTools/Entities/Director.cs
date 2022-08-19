using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
	[XmlRoot(ElementName = "director")]
	public class Director
	{

		[XmlAttribute(AttributeName = "tmdbid")]
		public int Tmdbid { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
