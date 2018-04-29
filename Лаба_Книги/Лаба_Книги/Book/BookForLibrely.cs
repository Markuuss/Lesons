using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_Книги
{
    abstract class BookForLibrely
    {
        public int NumberBook { get; private set; }
        public BookForLibrely(int number)
        {
            NumberBook = number;
        }
        public virtual void BookRead()
        {
            Console.WriteLine("Книгу читают");
        }
        public virtual void Book_on_shel()
        {
            Console.WriteLine("книга лежит на полке");
        }
        public abstract void SaleBook();

    }
}
