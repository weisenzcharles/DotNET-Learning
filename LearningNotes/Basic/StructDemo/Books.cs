﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    public struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;


        public void setValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }
        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }

    };
}
