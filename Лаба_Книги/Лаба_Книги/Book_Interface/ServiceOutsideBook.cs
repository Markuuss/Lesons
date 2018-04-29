using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_Книги
{
    abstract class ServiceOutsideBook : Interface_book
    {
        public virtual void PutPaper()
        {
            Console.WriteLine("Собраннна мукалатура!");
        }
      public abstract void Salebook();
    }
}
