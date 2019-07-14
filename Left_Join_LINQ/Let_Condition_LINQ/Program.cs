using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_Condition_LINQ
{

    class Program
    {

        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>
        {
            new Book{BookID=1, BookNm="programming WCF service"},
            new Book{BookID=2, BookNm="pro ASP.NET MVC5"},
            new Book{BookID=3, BookNm="Pro WPF in C# 2008"},
            new Book{BookID=4, BookNm="Programming Entity Framework"},
            new Book{BookID=5, BookNm="Fast ASP.NET Websites"}
        };

            List<Order> bookOrders = new List<Order>{
            new Order{OrderID=1, BookID=1, PaymentMode="Credit"},
            new Order{OrderID=2, BookID=5, PaymentMode="Cheque"},
            new Order{OrderID=3, BookID=1, PaymentMode="Cash"},
            new Order{OrderID=4, BookID=3, PaymentMode="Cheque"},
            new Order{OrderID=5, BookID=5, PaymentMode="Cash"},
            new Order{OrderID=6, BookID=4, PaymentMode="Cash"}
        };
            var orderForBooks = from bk in bookList
                                join ordr in bookOrders
                                on bk.BookID equals ordr.BookID
                                into a
                                from b in a.DefaultIfEmpty(new Order())
                                select new
                                {
                                    bk.BookID,
                                    Name = bk.BookNm,
                                    b.PaymentMode
                                };

            foreach (var item in orderForBooks)
                Console.WriteLine(item);

            Console.ReadLine();

        }

    }
    public class Book
    {
        public int BookID { get; set; }
        public string BookNm { get; set; }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public int BookID { get; set; }
        public string PaymentMode { get; set; }
    }



    
 }
