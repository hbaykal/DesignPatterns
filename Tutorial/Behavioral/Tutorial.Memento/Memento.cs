using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Memento
{
    public class Memento
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageNumber { get; set; }
        public DateTime LastUdateTime { get; set; }

        public Memento(string title, string author, int pageNumber, DateTime lastUpdateTime)
        {
            Title = title;
            Author = author;
            PageNumber = pageNumber;
            LastUdateTime = lastUpdateTime;
        }
    }
}
