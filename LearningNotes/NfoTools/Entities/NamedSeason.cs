using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{
	[XmlRoot(ElementName = "namedseason")]
	public class NamedSeason
	{

		[XmlAttribute(AttributeName = "number")]
		public int Number { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
