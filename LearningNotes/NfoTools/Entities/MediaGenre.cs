using System;
using System.Collections.Generic;
using System.Text;

namespace NfoTools.Entities
{
    public class MediaGenre
    {
        public static MediaGenre ACTION = new MediaGenre("ACTION", 0, "Action");

        private string name;
        private string[] alternateNames;

        private MediaGenre(string enumName, int ordinal, String name)
        {
            //super(enumName, ordinal);
            //this.name = name;
            //this.alternateNames = loadAlternateNames(enumName);

            //addElement();
        }
    }
}
