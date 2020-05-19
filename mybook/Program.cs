using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {
        class Book
        {
            public string name;
            public string firstPrint;
            public string writer;
            public string pubPerson;
            public string publisher;
            public string mainEditor;
            public string planner;
            public string editor;
            public string designer;
        }

        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(
                new Book()
                {
                    name="PHP 프로그래밍 입문",
                    firstPrint = "2013년 5월 20일",
                    writer="황재호",
                    pubPerson="김태헌",
                    publisher="한빛아카데미(주)",
                    mainEditor="김현용",
                    planner="김이화",
                    editor="김이화",
                    designer="여동일"
                }
            );
            foreach (var item in bookList) 
            {
                Console.WriteLine(item.name + " ("+item.writer+") " + item.publisher);
            }
        }
    }
}
