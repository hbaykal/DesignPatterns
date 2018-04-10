using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Memento
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _pageNumber;
        DateTime _lastUpdateTime;

        public string Title
        {
            get { return _title; }
            set { _title = value; SetUpdateTime(); }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; SetUpdateTime(); }
        }
        public int PageNumber
        {
            get { return _pageNumber; }
            set { _pageNumber = value; SetUpdateTime(); }
        }

        private void SetUpdateTime()
        {
            _lastUpdateTime = DateTime.UtcNow;
        }

        public Memento CreateUndo()
        {
            return new Memento(_title, _author, _pageNumber, _lastUpdateTime);
        }

        public void RestoreFromUndo(Memento memento)
        {
            _title = memento.Title;
            _author = memento.Author;
            _pageNumber = memento.PageNumber;
            _lastUpdateTime = memento.LastUdateTime;
        }

        public void ShowBookInfo()
        {
            Console.WriteLine("{0}; {1}; {2}; {3}", Title, Author, PageNumber, _lastUpdateTime);
        }
    }
}
