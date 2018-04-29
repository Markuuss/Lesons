using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_Книги
{
    class Program
    {
        static void Main(string[] args)
        {
            Name_Labrary name_Labrary = new Name_Labrary();
            name_Labrary.Book(10);
            name_Labrary.Salebook();
            Console.ReadKey();
        }

    }
}
