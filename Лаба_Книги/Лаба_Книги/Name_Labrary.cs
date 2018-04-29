using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_Книги
{
    class Name_Labrary : ServiceOutsideBook
    {
        List<BookForLibrely> _allBook;
        private delegate void DelegateRemoveBook();
        public string MagazinName { get; set; }
        public Name_Labrary(string name = null)
        {
            _allBook = new List<BookForLibrely>();
            if (name != null)
                MagazinName = name;
        }
        public void Book(int amount = 1)
        {
            for (int i = 0; i < amount; i++)
            {
                _allBook.Add(new book1(_allBook.Count));
            }
        }
        public override void Salebook()
        {
            Console.WriteLine("Количество на складе: {0}", _allBook.Count);
            Console.WriteLine("Выберите книгу на продажу");

            for (int i = 0; i < _allBook.Count; i++)
            {
                Console.WriteLine(_allBook[i].ToString());
            }
            int numberPc = Int32.Parse(Console.ReadLine());
            var Book = _allBook.First(c => c.NumberBook == numberPc);
            _allBook.Remove(Book);
            Book.SaleBook();
            Console.WriteLine("Количество на складе: {0}", _allBook.Count);
            F:
            Console.WriteLine("Выберите функцию книги: ");
            int vibor=Convert.ToInt32(Console.ReadLine());

            switch (vibor)
            {
                case 1:
                   
                    _allBook[0].BookRead();

                    goto F;
                case 2:
                    
                    _allBook[0].Book_on_shel();
                    goto F;
                case 3:
                    PutPaper();
                    goto F;
        }
            
        
            Console.ReadLine();


        }
    }
}
