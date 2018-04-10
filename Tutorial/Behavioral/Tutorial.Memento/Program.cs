using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tutorial.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Title = "Kuyucaklı Yusuf",
                Author = "Sebo",
                PageNumber = 198
            };
            book.ShowBookInfo();
            CareTaker history = new CareTaker();
            history.Memento = book.CreateUndo();
            Thread.Sleep(2000);

            book.Title = "Sultanı Öldürmek";
            book.Author = "Ahmet ümit";
            book.PageNumber = 421;
            book.ShowBookInfo();

            book.RestoreFromUndo(history.Memento);
            book.ShowBookInfo();

            Console.ReadLine();
        }

      
    }

    
}
