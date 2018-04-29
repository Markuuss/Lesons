using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_Книги
{
    class book1: BookForLibrely
    {
        public int CountChangeMotherboard { get; set; }
        public book1(int number) : base(number)
        {

        }
        public override void BookRead()
        {
            Console.WriteLine("Чтение книги: {0}");
        }
        public override void Book_on_shel()
        {
            Console.WriteLine("лежит на полке");
        }
        public override string ToString()
        {
            return $"Номер книги № {NumberBook}";
        }

        public override void SaleBook()
        {
            Console.WriteLine("Книга № " + NumberBook + " продан");
        }


    }
}
