﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{

    class Program
    {
       
        public static void Main(string[] args)
        {
            Boolean boolean = new Boolean();
            boolean = true;


            Books Book1;        /* 声明 Book1，类型为 Books */
            Books Book2;        /* 声明 Book2，类型为 Books */

            /* book 1 详述 */
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            //Book1.book_id = 6495407;

//            Book1.setValues("C Programming",
//"Nuha Ali", "C Programming Tutorial", 6495407);

            /* book 2 详述 */
            Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;
 
            /* 打印 Book1 信息 */
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            //Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            /* 打印 Book2 信息 */
            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

            Console.ReadKey();

        }

        public static void testStructure()
        {


            Books Book1 = new Books(); /* 声明 Book1，类型为 Books */
            Books Book2 = new Books(); /* 声明 Book2，类型为 Books */

            /* book 1 详述 */
            Book1.setValues("C Programming",
            "Nuha Ali", "C Programming Tutorial", 6495407);

            /* book 2 详述 */
            Book2.setValues("Telecom Billing",
            "Zara Ali", "Telecom Billing Tutorial", 6495700);

            /* 打印 Book1 信息 */
            Book1.display();

            /* 打印 Book2 信息 */
            Book2.display();

            Console.ReadKey();


        }
    }
}
