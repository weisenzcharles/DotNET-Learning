using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    public readonly struct User
    {
        public readonly string name;

        public void setValues(string t, string a, string s, int id)
        {
            //name = t;
            //author = a;
            //subject = s;
            //book_id = id;
        }
    }

    //public readonly struct Coords
    //{

    //    public Coords(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public double X { get; init; }
    //    public double Y { get; init; }

    //    public override string ToString() => $"({X}, {Y})";
    //}
}
