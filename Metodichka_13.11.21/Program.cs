using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka_13._11._21
{
    class Program
    {
        static void Main(string[] args)
        {
            ACipher aCipher = new ACipher();
            BCipher bCipher = new BCipher();
            Console.WriteLine("Упражнение 10.1. Введите текст");
            string s = Console.ReadLine();
            string codeS = ((ICipher)aCipher).encode(s);
            string encodeS = ((ICipher)aCipher).decode(codeS);
            Console.WriteLine($"Шифр А\nИсходный текст '{s}'\nЗакодированный текст '{codeS}'\nРаскодированный текст '{encodeS}'\n");
            codeS = ((ICipher)bCipher).encode(s);
            encodeS = ((ICipher)bCipher).decode(codeS);
            Console.WriteLine($"Шифр Б\nИсходный текст '{s}'\nЗакодированный текст '{codeS}'\nРаскодированный текст '{encodeS}'\n\n");

            Console.WriteLine("Домашнее задание 10.1");
            Point point = new Point(Color.Blue, Status.Visible, 0.3, 1.4);
            Circle circle = new Circle(Color.Green, Status.Invisible,-5, -3, 1.8);
            Rectangle rectangle = new Rectangle(Color.Black, Status.Visible, 1, 1, 5, 11, 15, 7.5);
            point.ShowInfo();
            circle.ShowInfo();
            rectangle.ShowInfo();
        }
    }
}
