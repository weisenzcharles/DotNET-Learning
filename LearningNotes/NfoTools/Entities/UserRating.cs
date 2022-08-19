using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NfoTools.Entities
{

	[XmlRoot(ElementName = "UserRating")]
	public class UserRating
	{

		[XmlAttribute(AttributeName = "max")]
		public int Max { get; set; }

		[XmlText]
		public int Text { get; set; }
	}
}
