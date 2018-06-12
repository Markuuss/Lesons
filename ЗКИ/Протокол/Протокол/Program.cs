using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Протокол
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите число r:");
            int r = int.Parse(Console.ReadLine()); 
            r = Proverka(r, n);
            float x = (float)Math.Pow(r, 2) % n;
            float v = 0;
            while (true)
            {
                if (Math.Pow(x, 2) % n == v % n)
                    break;
                else v += 1;
            }
            Random rand = new Random();
            int b = rand.Next(0, 1);
            float s = 0, y = 0;
            while (true)
            {
                if (Math.Pow(s, 2) % n == v)
                    break;
                else s += 1;
            }
            Console.WriteLine("X=" + x);
            Console.WriteLine("Открытый ключ v=" + v);
            Console.WriteLine("Секретный ключ s=" + s);
            if (b == 0)
            {
                
                if (x == Math.Pow(r, 2) % n)
                {
                    Console.WriteLine("R отправлено B");
                }
                else
                    Console.WriteLine("Не прошло проверку");
            }
            else if(b == 1)
            {
                
                if (x == Math.Pow(r, 2) % n)
                {
                    y = r * s % n;
                    Console.WriteLine("А отправила B {y}");
                }
                else
                    Console.WriteLine("Не прошло проверку");
            }
            Console.ReadLine();
        }
        static int Proverka(int r, int n)
        {
            do
            {
                if (r > n)
                {
                    Console.WriteLine("Неверно, r>n. Введите еще раз\n");
                    r = Convert.ToInt32(Console.ReadLine());
                }

            }
            while (r > n);
            return r;
        }
    }
}
